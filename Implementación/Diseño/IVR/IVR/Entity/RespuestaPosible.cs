using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace IVR.Entity
{
    public class RespuestaPosible
    {
        // Atributos
        [Key]
        public int RespuestaPosibleId { get; set; } // Fabricacion pura

        public string Descripcion { get; set; }

        public int Valor { get; set; }

        [ForeignKey("Pregunta")]
        public int? PreguntaId { get; set; } // Fabricacion pura
        public Pregunta Pregunta { get; set; } // Fabricacion pura


        // Metodos
        public RespuestaPosible(string descripcion, int valor)
        {
            this.Descripcion = descripcion;
            this.Valor = valor;
        }

        public RespuestaPosible() { }

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

            preguntasYrespuestas.Rows.Add(descPregunta, Descripcion); // Recién en este punto se agrega una nueva fila a la grilla, con la información de la respuesta y la pregunta
        }
    }
}