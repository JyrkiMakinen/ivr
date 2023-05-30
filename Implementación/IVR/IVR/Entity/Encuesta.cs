using System;
using System.Collections.Generic;

namespace IVR.Entity
{
    public class Encuesta
    {
        private List<Pregunta> preguntas;
        private DateTime dateTime;
        private string descripcion;

        public Encuesta(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public Encuesta(string descripcion, DateTime dateTime)
        {
            this.descripcion = descripcion;
            this.dateTime = dateTime;
        }

        public List<Pregunta> getPreguntas() {
            return preguntas;
        }

        public void setPreguntas(List<Pregunta> preguntas)
        {
            this.preguntas = preguntas;
        }

        public string getDescripcionEncuesta() {
            return descripcion;
        }
    }
}