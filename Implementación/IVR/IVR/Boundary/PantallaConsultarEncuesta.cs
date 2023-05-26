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
        private GestorConsutarEncuesta gestor;

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
            gestor.opcionConsultarEncuesta();
        }

        public void habilitarPantalla() {
            InitializeComponent();
        }

        public void solicitarPeriodo() {
            //Por pantalla que ingre fecha desde y hasta
        }

        public void tomarFechaInicio() {
            //reemplazar esto por datos cargados en la pantalla
            this.fechaInicio = new DateTime(2023, 5, 24, 0, 0, 0);
        }

        public void tomarFechaFin() {
            //reemplazar esto por datos cargados en la pantalla
            this.fechaFin = new DateTime(2023, 5, 25, 0, 0, 0);

            //Aca llamamos al gestor en tomar periodo? o en algun boton que diga buscar?
            gestor.tomarPeriodo(fechaInicio, fechaFin);
        }

        public void solicitarSeleccionLlamada(List<Llamada> llamdasConEncuestasRespondidasDelPeriodo) {

            //mostrar en una grilla seleccionable las llamadas con encuestas respondidas del periodo

        }

        public void tomarSeleccionLlamada() {
            //Pasamos por parametro las llamdas selecciondas de la grid
            gestor.tomarSeleccionLlamada(llamadaSeleccionada);
        }

        public void mostrarEncuesta() {

        }

        public void soliciarSeleccionFormaVisualización() {

        }

        public void tomarSeleccionFormaVisualización() {

        }



    }
}
