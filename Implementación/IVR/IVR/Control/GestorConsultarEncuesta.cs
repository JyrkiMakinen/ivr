using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVR.Boundary;

namespace IVR.Control
{   

    public class GestorConsultarEncuesta
    {
        public DateTime fechaInicioPeriodo { get; set; }
        public DateTime fechaFinPeriodo { get; set; }
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;

        public GestorConsultarEncuesta() {

            this.pantallaConsultarEncuesta = new PantallaConsultarEncuesta();
        }

        public void opcionConsultarEncuesta() {

        }

        public void tomarPeriodo()
        {
            this.fechaInicioPeriodo = pantallaConsultarEncuesta.getFechaInicio();
            this.fechaFinPeriodo = pantallaConsultarEncuesta.getFechaFinPeriodo();
        }


        public void buscarLlamadasConEncRespondidas() {

        }

        public void tomarSeleccionLlamada() {

        }


        public void obtenerDatos() {

        }

        public void tomarSeleccionFormaVisualizacion() {

        }

        public void generarCsv() {

        }

        public void finCU() {

        }
    }
}
