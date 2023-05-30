using System;

namespace IVR.Entity
{
    public class RespuestaPosible
    {

        private string descripcion;
        private Pregunta pregunta;
        private int valor;

        public RespuestaPosible(Pregunta pregunta, string descripcion, int valor)
        {
            this.pregunta = pregunta;
            this.descripcion = descripcion;
            this.valor = valor;
        }

        public string getDescripcion() {
            return descripcion;
        }

        public void setDescripcion(string descripcion) {
            this.descripcion = descripcion;
        }

        public string obtenerDescripcionRta()
        {
            return pregunta.obtenerDescripcionPregunta();
        }
    }
}