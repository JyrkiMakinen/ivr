using System;
using System.Collections.Generic;

namespace IVR.Entity
{
    public class Encuesta
    {
        private string descripcion;
        private List<Pregunta> preguntas;
        private DateTime fechaFinVigencia;

        public Encuesta(string descripcion, List<Pregunta> preguntas, DateTime fechaFinVigencia)
        {
            this.descripcion = descripcion;
            this.preguntas = preguntas;
            this.fechaFinVigencia = fechaFinVigencia;
        }

        public bool esTuPregunta(Pregunta pregunta)
        {
            if (preguntas.Contains(pregunta))
            {
                return true;
            }
            return false;
        }

        public string getDescripcionEncuesta()
        {
            return descripcion;
        }
    }
}