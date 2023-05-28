using IVR.Control;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IVR.Boundary
{
    public partial class PantallaConsultarEncuesta : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private GestorConsultarEncuesta gestor;

        public PantallaConsultarEncuesta()
        {
            opcionConsultarEncuesta();
        }

        public void opcionConsultarEncuesta()
        {
            habilitarPantalla();
        }

        public void habilitarPantalla()
        {
            InitializeComponent();
            gestor.opcionConsultarEncuesta();
        }

        public void solicitarPeriodo()
        {
            //Esperar a que seleccione fechas
        }

        public void tomarFechaInicio(object sender, EventArgs e)
        {
            //Esperar a que seleccione fecha fin
        }

        public void tomarFechaFin()
        {
            gestor.tomarPeriodo(dtpInicio.Value, dtpFin.Value);
        }

        public void solicitarSeleccionLlamada(List<Llamada> llamdasConEncuestasRespondidasDelPeriodo)
        {
            cmbLlamada.DataSource = 
        }


        public DateTime getFechaInicio()
        {
            return fechaInicio;
        }

        public DateTime getFechaFin()
        {
            return fechaFin;
        }

        public void tomarSeleccionLlamada()
        {
            //Pasamos por parametro las llamdas selecciondas de la grid
            gestor.tomarSeleccionLlamada(llamadaSeleccionada);
        }

        public void mostrarEncuesta()
        {

        }

        public void soliciarSeleccionFormaVisualización()
        {

        }

        public void tomarSeleccionFormaVisualización()
        {

        }


    }
}
