using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVR.Boundary;
using IVR.Datos;
using IVR.Entity;

namespace IVR.Control
{

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;
        private string nombreCliente;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantalla) {
            this.generadorDeDatos = new GeneradorDeDatos();
            this.pantallaConsultarEncuesta = pantalla;
        }

        public void opcionConsultarEncuesta() {
            pantallaConsultarEncuesta.solicitarPeriodo();
        }
        
        public void tomarPeriodo()
        {
            this.fechaInicioPeriodo = pantallaConsultarEncuesta.getFechaInicio();
            this.fechaFinPeriodo = pantallaConsultarEncuesta.getFechaFin();
            buscarLlamadasConEncRespondidas();
        }


        public List<Llamada> buscarLlamadasConEncRespondidas() {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamdasConEncuestasRespondidasDelPeriodo = new List<Llamada>();
            for (int i = 0; i < listLlamadas.Count(); i++) {
                if (listLlamadas[i].tieneEncuestasRespondidas()) {
                    if (listLlamadas[i].esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo)) {
                        llamdasConEncuestasRespondidasDelPeriodo.Add(listLlamadas[i]);
                    }
                }
            }

            pantallaConsultarEncuesta.solicitarSeleccionLlamada(llamdasConEncuestasRespondidasDelPeriodo);
        }

        public void tomarSeleccionLlamada(Llamada llamadaSeleccionada) {
            obtenerDatos(llamadaSeleccionada);
        }


        public void obtenerDatos(Llamada llamadaSeleccionada) {
            this.nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();

            //que recibe esto? el nombre del estado o el "Estado" o el "cambio de estado??
            llamadaSeleccionada.getEstadoActual();


            llamadaSeleccionada.getRespuestas();

            pantallaConsultarEncuesta.mostrarEncuesta();
            pantallaConsultarEncuesta.solicitarSeleccionFormaVisualizacon();
        }

        public void tomarSeleccionFormaVisualizacion(string formaVisualizacion) {
            if (formaVisualizacion.Equals("csv")) {
                generarCsv();
            }
        }

        public void generarCsv() {
            //generar el csv


            finCU();
        }

        public void finCU() {

        }


        public void setFechaInicioPeriodo(DateTime dateTime)
        {
            this.fechaInicioPeriodo = dateTime;
        }

        public void setFechaFinPeriodo(DateTime dateTime)
        {
            this.fechaFinPeriodo = dateTime;
        }

        public DateTime setFechaInicioPeriodo()
        {
            return this.fechaInicioPeriodo;
        }

        public DateTime setFechaFinPeriodo()
        {
            return this.fechaFinPeriodo;
        }

    }
}
