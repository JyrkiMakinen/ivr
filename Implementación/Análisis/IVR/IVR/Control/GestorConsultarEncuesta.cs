using IVR.Boundary;
using IVR.Datos;
using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace IVR.Control
{

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;
        private DataTable preguntasYrespuestas;
        private string nombreCliente;

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
            nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoActual = llamadaSeleccionada.getEstadoActual();
            TimeSpan duracion = llamadaSeleccionada.getDuracion();

            // En esta tabla van a ir las preguntas y respuestas. Se crea vacía con dos columnas
            preguntasYrespuestas = new DataTable();
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
            // Definir la ruta relativa y el nombre del archivo CSV
            string csvFilePath = @"..\..\..\..\..\..\Encuesta_" + nombreCliente + ".csv";
            
            using (FileStream fileStream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    // Escribir una línea de encabezado en el archivo CSV
                    writer.WriteLine("Preguntas,Respuestas");

                    foreach (DataRow row in preguntasYrespuestas.Rows)
                    {
                        // Obtener los valores de las columnas de la fila actual
                        string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();

                        // Escribir los valores en el archivo CSV
                        writer.WriteLine(string.Join(",", fields));
                    }
                }
            }

            finCU();
        }

        public void finCU()
        {
            pantallaConsultarEncuesta.Close();
        }


    }
}
