using System.Collections.Generic;

namespace IVR.Entity
{
    public class Pregunta
    {
        private string descripcion;
        private List<RespuestaPosible> respuestasPosibles;
        private Encuesta encuesta;

        public Pregunta(string descripcion, Encuesta encuesta){
            this.encuesta = encuesta;
            this.descripcion = descripcion;
        }

        public List<RespuestaPosible> getRespuestasPosibles() {
            return respuestasPosibles;
        }

        public void setRespuestasPosibles(List<RespuestaPosible> respuestasPosibles) {
            this.respuestasPosibles = respuestasPosibles;
        }

        public string obtenerDescripcionPregunta() {
            return encuesta.getDescripcionEncuesta();
        }
    }
}