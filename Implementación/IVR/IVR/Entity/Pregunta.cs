using System.Collections.Generic;

namespace IVR.Entity
{
    public class Pregunta
    {
        private string descripcion;
        private List<RespuestaPosible> respuestasPosibles;

        public Pregunta(string descripcion, List<RespuestaPosible> respuestasPosibles)
        {
            this.descripcion = descripcion;
            this.respuestasPosibles = respuestasPosibles;
        }

        public List<RespuestaPosible> getRespuestasPosibles() {
            return respuestasPosibles;
        }

        public void setRespuestasPosibles(List<RespuestaPosible> respuestasPosibles) {
            this.respuestasPosibles = respuestasPosibles;
        }

        public string obtenerDescripcionPregunta(ref string descripcionEncuesta, List<Encuesta> allEncuestas) 
        {
            foreach (Encuesta encuesta in allEncuestas)
            {
                if (encuesta.esTuPregunta(this))
                {
                    descripcionEncuesta = encuesta.getDescripcionEncuesta(); // Recién en este punto se obtiene la descripción de la encuesta
                    break;
                }
            }

            return descripcion;
        }

        public bool esTuRespuesta(RespuestaPosible respuesta)
        {
            if (respuestasPosibles.Contains(respuesta))
            {
                return true;
            }
            return false;
        }
    }
}