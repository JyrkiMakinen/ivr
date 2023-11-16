using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IVR.Entity
{
    public class Encuesta
    {
        // Atributos
        [Key]
        public int EncuestaId { get; set; } // Fabricacion pura

        public string Descripcion { get; set; }

        public List<Pregunta> Preguntas { get; set; }

        public DateTime FechaFinVigencia { get; set; }


        // Metodos
        public Encuesta(string descripcion, List<Pregunta> preguntas, DateTime fechaFinVigencia)
        {
            this.Descripcion = descripcion;
            this.Preguntas = preguntas;
            this.FechaFinVigencia = fechaFinVigencia;
        }

        public bool esTuPregunta(Pregunta pregunta)
        {
            if (Preguntas.Contains(pregunta))
            {
                return true;
            }
            return false;
        }

        public string getDescripcionEncuesta()
        {
            return Descripcion;
        }
    }
}