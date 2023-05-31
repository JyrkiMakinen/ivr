using System;
using System.Collections.Generic;
using System.Data;

namespace IVR.Entity
{
    public class RespuestaPosible
    {
        private string descripcion;
        private int valor;

        public RespuestaPosible(string descripcion, int valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;
        }

        public string getDescripcion() {
            return descripcion;
        }

        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }

        public void obtenerDescripcionRta(ref DataTable preguntasYrespuestas, ref string descripcionEncuesta, List<Pregunta> allPreguntas, List<Encuesta> allEncuestas)
        {
            string descPregunta = "";

            foreach (Pregunta pregunta in allPreguntas)
            {
                if (pregunta.esTuRespuesta(this))
                {
                    descPregunta = pregunta.obtenerDescripcionPregunta(ref descripcionEncuesta, allEncuestas);
                    break;
                }
            }

            preguntasYrespuestas.Rows.Add(descPregunta, descripcion); // Recién en este punto se agrega una nueva fila a la grilla, con la información de la respuesta y la pregunta
        }
    }
}