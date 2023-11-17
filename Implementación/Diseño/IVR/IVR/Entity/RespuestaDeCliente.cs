using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace IVR.Entity
{
    public class RespuestaDeCliente
    {
        // Atributos
        [Key]
        public int RespuestaDeClienteId { get; set; } // Fabricacion pura

        [ForeignKey("RespuestaPosible")]
        public int? RespuestaPosibleId { get; set; } // Fabricacion pura
        public RespuestaPosible RespuestaPosible { get; set; }

        [ForeignKey("Llamada")]
        public int? LlamadaId { get; set; } // Fabricacion pura
        public Llamada Llamada { get; set; } // Fabricacion pura


        // Metodos
        public RespuestaDeCliente(RespuestaPosible respuestaSeleccionada)
        {
            this.RespuestaPosible = respuestaSeleccionada;
        }

        public RespuestaDeCliente() { }

        public void obtenerDescripcionRta(ref DataTable preguntasYrespuestas, ref string descripcionEncuesta, List<Pregunta> allPreguntas, List<Encuesta> allEncuestas)
        {
            RespuestaPosible.obtenerDescripcionRta(ref preguntasYrespuestas, ref descripcionEncuesta, allPreguntas, allEncuestas);
        }
    }
}