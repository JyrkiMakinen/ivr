using IVR.Control;
using IVR.Entity;
using System;
using System.Collections.Generic;
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
            gestor.tomarPeriodo(dtpInicio.Value, dtpFin.Value);
        }

        public void tomarFechaFin()
        {
            gestor.tomarPeriodo(dtpInicio.Value, dtpFin.Value);
        }

        public void solicitarSeleccionLlamada(List<Llamada> llamadas)
        {
           this.llamadas = llamadas;
           isComboBoxLoading = true;
           cmbLlamada.DataSource = llamadas.Select(llamada => new { Id = llamada.getId(), Cliente = llamada.getNombreClienteDeLlamada()}).ToList();
           cmbLlamada.DisplayMember = "Cliente";
           cmbLlamada.ValueMember = "Id";
           isComboBoxLoading = false;
        }

        private void tomarSeleccionLlamada(object sender, EventArgs e)
        {
            dynamic selectedItem = cmbLlamada.SelectedItem;
            long idLlamada = selectedItem.Id;
            
            if (idLlamada != null)
            {
                foreach (Llamada llamada in llamadas)
                {
                    if (llamada.getId() == idLlamada)
                    {
                        gestor.tomarSeleccionLlamada(llamada);
                    }
                }
            }
        }

        private void tomarSeleccionLlamada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isComboBoxLoading)
            {
                return; // Salir del evento sin realizar ninguna acción
            }
        }

        public void mostrarEncuesta(string nombreCliente, string estadoActual, TimeSpan duracion, List<RespuestaDeCliente> respuestas)
        {
            // Recibo todos los datos que me van a mandar los wachines del gestor
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
