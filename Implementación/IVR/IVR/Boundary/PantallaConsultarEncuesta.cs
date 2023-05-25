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
    public partial class PantallaConsultarEncuesta : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public DateTime getFechaInicio () {
            return fechaInicio;
        }

        public DateTime getFechaFin()
        {
            return fechaFin;
        }

        public PantallaConsultarEncuesta()
        {
            habilitarPantalla();
        }

        public void habilitarPantalla() {
            InitializeComponent();
        }

        public void solicitarPeriodo() {

        }

        public void tomarFechaInicio() {
            this.fechaInicio = new DateTime(2023, 5, 24, 0, 0, 0);
        }

        public void tomarFechaFin() {
            this.fechaFin = new DateTime(2023, 5, 25, 0, 0, 0);
        }

        public void solicitarSeleccionLlamada() {

        }

        public void mostrarEncuesta() {

        }

        public void soliciarSeleccionFormaVisualización() {

        }

        public void tomarSeleccionFormaVisualización() {

        }



    }
}
