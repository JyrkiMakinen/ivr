using System;

namespace IVR.Entity
{
    public class RespuestaDeCliente
    {

        private RespuestaPosible respuestaPosible;
        private DateTime fechaEncuesta;
        private string descripcion;

        public RespuestaDeCliente(RespuestaPosible respuestaPosible)
        {
            this.respuestaPosible = respuestaPosible;
        }

        public string obtenerDescripcionRta() {
            return this.respuestaPosible.getDescripcion();
        }

        public string obtenerDescripcionPregunta() {
           return this.respuestaPosible.obtenerDescripcionPregunta();
        }

        public string obtenerDescripcionEncuesta() {
            return this.respuestaPosible.obtenerDescripcionEncuesta();
        }
    }
}