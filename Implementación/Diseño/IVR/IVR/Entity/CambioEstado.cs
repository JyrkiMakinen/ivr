using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IVR.Entity
{
    public class CambioEstado
    {
        // Atributos
        [Key]
        public int CambioEstadoId { get; set; } // Fabricacion pura

        public DateTime FechaHoraInicio { get; set; }

        public DateTime? FechaHoraFin { get; set; }

        [ForeignKey("Estado")]
        public int? EstadoId { get; set; } // Fabricacion pura
        public Estado Estado { get; set; }

        [ForeignKey("Llamada")]
        public int? LlamadaId { get; set; } // Fabricacion pura
        public Llamada Llamada { get; set; } // Fabricacion pura


        // Metodos
        public CambioEstado(DateTime fechaHoraInicio, DateTime? fechaHoraFin, Estado estado)
        {
            this.FechaHoraInicio = fechaHoraInicio;
            this.FechaHoraFin = fechaHoraFin;
            this.Estado = estado;
        }

        public bool esEstadoIniciada()
        {
            return Estado.esIniciada();
        }

        public DateTime getFechaHoraInicio()
        {
            return FechaHoraInicio;
        }

        public bool esUltimoEstado()
        {
            if (FechaHoraFin == null)
            {
                return true;
            }
            return false;
        }

        public string getNombreEstado()
        {
            return Estado.getNombre();
        }

    }
}