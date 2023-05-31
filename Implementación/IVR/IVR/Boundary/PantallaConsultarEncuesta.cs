using IVR.Control;
using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IVR.Boundary
{
    public partial class PantallaConsultarEncuesta : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private GestorConsultarEncuesta gestor;
        private List<Llamada> llamadas;
        private bool isComboBoxLoading;

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
            gestor = new GestorConsultarEncuesta(this);
            gestor.opcionConsultarEncuesta();
        }

        public void solicitarPeriodo()
        {
            pnlPeriodo.Visible = true;
        }

        public void tomarFechaInicio(object sender, EventArgs e)
        {
            gestor.tomarPeriodo(dtpInicio.Value, dtpFin.Value); // No está en la secuencia. Nos tomamos esta licencia para que se actualicen las llamadas si el usuario cambia la fecha inicio después de elegir la fecha fin
        }

        public void tomarFechaFin(object sender, EventArgs e)
        {
            gestor.tomarPeriodo(dtpInicio.Value, dtpFin.Value);
        }

        public void solicitarSeleccionLlamada(List<Llamada> llamadas, List<string> etiquetas)
        {
            this.llamadas = llamadas;
            cmbLlamada.DataSource = etiquetas;
        }

        private void tomarSeleccionLlamada(object sender, EventArgs e)
        {
            int indiceLlamada = cmbLlamada.SelectedIndex;
            Llamada llamadaSeleccionada = llamadas[indiceLlamada]; // Recupero el objeto Llamada según el índice del cmb elegido.

            gestor.tomarSeleccionLlamada(llamadaSeleccionada);
        }

        public void mostrarEncuesta(string nombreCliente, string estadoActual, TimeSpan duracion, String encuesta, DataTable preguntasYrespuestas)
        {
            lblCliente.Text = nombreCliente;
            lblEstado.Text = estadoActual;
            lblDuracion.Text = duracion.ToString(@"hh\:mm\:ss"); ;
            lblEncuesta.Text = encuesta;
            
            grdEncuesta.DataSource = preguntasYrespuestas;

            cmbFormaVisualizacion.Enabled = true;

        }

        public void solicitarSeleccionFormaVisualizacion()
        {
            // Esperar que se aprete el botón de Generar Archivo
        }

        public void tomarSeleccionFormaVisualización(object sender, EventArgs e)
        {
            if (cmbFormaVisualizacion.SelectedIndex == 0) 
            {
                gestor.generarCsv();
                MessageBox.Show("¡Archivo generado exitosamente!", "Atención");
            }
            else if (cmbFormaVisualizacion.SelectedIndex == -1)
            {
                MessageBox.Show("Elija una forma de visualización.", "Atención");
            }
            else
            {
                MessageBox.Show("Funcionalidad no implementada.", "Atención");
            }
        }
    }
}
