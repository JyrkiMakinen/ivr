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
        private List<Llamada> llamadas;

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

        public void solicitarSeleccionLlamada(List<Llamada> llamadas, List<DateTime> fechasHorasLlamadas)
        {
            this.llamadas = llamadas;
            cmbLlamada.DataSource = fechasHorasLlamadas; // Muestro las horas de las llamadas. En tomarSeleccionLlamada() método vuelvo a vincular cada hora con su respectivo objeto Llamada.
        }

        private void tomarSeleccionLlamada(object sender, EventArgs e)
        {
            int indiceLlamada = cmbLlamada.SelectedIndex;
            Llamada llamadaSeleccionada = llamadas[indiceLlamada]; // Recupero el objeto Llamada según el índice del cmb elegido.

            gestor.tomarSeleccionLlamada(llamadaSeleccionada);
        }

        public void mostrarEncuesta(/* mil cosas */)
        {
            // Recibo todos los datos que me van a mandar los wachines del gestor
        }

        public void soliciarSeleccionFormaVisualización()
        {

        }

        public void tomarSeleccionFormaVisualización()
        {

        }


    }
}
