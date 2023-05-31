using System;
using System.Collections.Generic;
using System.Data;

namespace IVR.Entity
{
    public class RespuestaDeCliente
    {
        private RespuestaPosible respuestaSeleccionada;
        private DateTime fechaEncuesta; // Crearlas en el generador

        public RespuestaDeCliente(RespuestaPosible respuestaSeleccionada)
        {
            this.respuestaSeleccionada = respuestaSeleccionada;
        }

        public void obtenerDescripcionRta(ref DataTable preguntasYrespuestas, ref string descripcionEncuesta, List<Pregunta> allPreguntas, List<Encuesta> allEncuestas)
        {
            respuestaSeleccionada.obtenerDescripcionRta(ref preguntasYrespuestas, ref descripcionEncuesta, allPreguntas, allEncuestas);
        }
    }
}