using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVR.Boundary
{
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            lblCargando.Visible = true;
            prgBar.Visible = true;

            for(int i = 0; i < 5; i++)
            {
                prgBar.Increment(i * 10);
                System.Threading.Thread.Sleep(500);
            }
 
            Form pantalla = new PantallaConsultarEncuesta();
            pantalla.Show();
            Hide();
        }
    }
}
