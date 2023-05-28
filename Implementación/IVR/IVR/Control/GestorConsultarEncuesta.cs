using IVR.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IVR.Control
{

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;
        private string nombreCliente;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantalla)
        {
            this.generadorDeDatos = new GeneradorDeDatos();
            this.pantallaConsultarEncuesta = pantalla;
        }

        public void opcionConsultarEncuesta()
        {
            pantallaConsultarEncuesta.solicitarPeriodo();
        }

        public void tomarPeriodo()
        {
            this.fechaInicioPeriodo = pantallaConsultarEncuesta.getFechaInicio();
            this.fechaFinPeriodo = pantallaConsultarEncuesta.getFechaFin();
            buscarLlamadasConEncRespondidas();
        }


        public List<Llamada> buscarLlamadasConEncRespondidas()
        {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamadasConEncuestasRespondidasDelPeriodo = new List<Llamada>();
            foreach (Llamada llamada in listLlamadas)
            {
                if (llamada.tieneEncuestasRespondidas())
                {
                    if (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo))
                    {
                        llamadasConEncuestasRespondidasDelPeriodo.Add(llamada);
                        // Hay que conseguir la fecha y hora de esta llamada para mostrarla por pantalla
                    }
                }
            }

            pantallaConsultarEncuesta.solicitarSeleccionLlamada(llamadasConEncuestasRespondidasDelPeriodo);
        }

        public void tomarSeleccionLlamada(Llamada llamadaSeleccionada)
        {
            obtenerDatos(llamadaSeleccionada);
        }


        public void obtenerDatos(Llamada llamadaSeleccionada)
        {
            this.nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();

            //que recibe esto? el nombre del estado o el "Estado" o el "cambio de estado??
            llamadaSeleccionada.getEstadoActual();


            llamadaSeleccionada.getRespuestas();

            pantallaConsultarEncuesta.mostrarEncuesta();
            pantallaConsultarEncuesta.solicitarSeleccionFormaVisualizacon();
        }

        public void tomarSeleccionFormaVisualizacion(string formaVisualizacion)
        {
            if (formaVisualizacion.Equals("csv"))
            {
                generarCsv();
            }
        }

        public void generarCsv()
        {
            //generar el csv


            finCU();
        }

        public void finCU()
        {
            
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
