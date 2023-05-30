using IVR.Boundary;
using IVR.Datos;
using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IVR.Control
{

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private string nombreCliente;
        private TimeSpan duracion;
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantalla)
        {
            this.generadorDeDatos = new GeneradorDeDatos();
            this.pantallaConsultarEncuesta = pantalla;
        }

        public void opcionConsultarEncuesta()
        {
            pantallaConsultarEncuesta.solicitarPeriodo();
        }
        
        public void tomarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicioPeriodo = fechaInicio;
            this.fechaFinPeriodo = fechaFin;
            buscarLlamadasConEncRespondidas();
        }

        public void buscarLlamadasConEncRespondidas()
        {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamadasConEncuestasRespondidasDelPeriodo = new List<Llamada>();
            List<DateTime> fechasYHorasDeLlamadasConEncResp = new List<DateTime>();
            //List<String> listClientes = new List<string>;
            foreach (Llamada llamada in listLlamadas)
            {
                if (llamada.tieneEncuestasRespondidas())
                {
                    if (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo))
                    {
                        llamadasConEncuestasRespondidasDelPeriodo.Add(llamada);
                       // fechasYHorasDeLlamadasConEncResp.Add(llamada.getFechaHoraInicio());
                       // listClientes.Add(llamada.get)
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
            nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoActual = llamadaSeleccionada.getEstadoActual();
            duracion = llamadaSeleccionada.getDuracion();
            List<RespuestaDeCliente> respuestasCliente = llamadaSeleccionada.getRespuestas();

            pantallaConsultarEncuesta.mostrarEncuesta(nombreCliente, estadoActual, duracion, respuestasCliente);
            pantallaConsultarEncuesta.solicitarSeleccionFormaVisualizacion();
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
