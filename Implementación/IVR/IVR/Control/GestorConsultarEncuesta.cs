using IVR.Boundary;
using IVR.Datos;
using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IVR.Control
{

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantalla)
        {
            generadorDeDatos = new GeneradorDeDatos();
            pantallaConsultarEncuesta = pantalla;
        }

        public void opcionConsultarEncuesta()
        {
            pantallaConsultarEncuesta.solicitarPeriodo();
        }
        
        public void tomarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            fechaInicioPeriodo = fechaInicio;
            fechaFinPeriodo = fechaFin;
            buscarLlamadasConEncRespondidas();
        }

        public void buscarLlamadasConEncRespondidas()
        {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamadasConEncuestasRespondidasDelPeriodo = new List<Llamada>();
            List<string> etiquetasLlamadas = new List<string>();
            foreach (Llamada llamada in listLlamadas)
            {
                if (llamada.tieneEncuestasRespondidas())
                {
                    if (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo, out CambioEstado inicial))
                    {
                        llamadasConEncuestasRespondidasDelPeriodo.Add(llamada);

                        string etiqueta = llamada.getNombreClienteDeLlamada() + " - " + inicial.getFechaHoraInicio().ToString();
                        etiquetasLlamadas.Add(etiqueta);
                    }
                }
            } 
            pantallaConsultarEncuesta.solicitarSeleccionLlamada(llamadasConEncuestasRespondidasDelPeriodo, etiquetasLlamadas);
        }

        public void tomarSeleccionLlamada(Llamada llamadaSeleccionada)
        {
            obtenerDatosLlamada(llamadaSeleccionada);
        }

        public void obtenerDatosLlamada(Llamada llamadaSeleccionada)
        {
            string nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoActual = llamadaSeleccionada.getEstadoActual();
            TimeSpan duracion = llamadaSeleccionada.getDuracion();

            // En esta tabla van a ir las preguntas y respuestas. Se crea vacía con dos columnas
            DataTable preguntasYrespuestas = new DataTable();
            preguntasYrespuestas.Columns.Add("preguntas");
            preguntasYrespuestas.Columns.Add("respuestas");

            // Aquí se va a guardar la descripción de la encuesta
            string descripcionEncuesta = "";

            // Todas las preguntas, para que las respuestas encuentren cuál es su pregunta
            List<Pregunta> allPreguntas = generadorDeDatos.getPreguntas();

            //Todas las encuestas, para que las preguntas encuentren cuál es su encuesta
            List<Encuesta> allEncuestas = generadorDeDatos.getEncuestas();

            llamadaSeleccionada.obtenerPreguntasYRespuestas(ref preguntasYrespuestas, ref descripcionEncuesta, allPreguntas, allEncuestas);

            pantallaConsultarEncuesta.mostrarEncuesta(nombreCliente, estadoActual, duracion, descripcionEncuesta, preguntasYrespuestas);
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
