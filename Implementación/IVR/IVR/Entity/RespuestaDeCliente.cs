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
            return this.respuestaPosible.obtenerDescripcionRta();
        }
    }
}