using System;
namespace IVR.Entity
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio { get; set; }
        private DateTime? fechaHoraFin { get; set; }
        private Estado estado { get; set; }

        public CambioEstado(DateTime fechaHoraInicio, DateTime? fechaHoraFin, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.estado = estado;
        }

        public bool esEstadoInicial()
        {
            return estado.esIniciada();
        }

        public bool esUltimoEstado()
        {
            if (fechaHoraFin == null)
            {
                return true;
            }
            return false;
        }

        public string getNombreEstado() {
            return estado.getNombre();
        }

        public DateTime getFechaHoraInicio() {
            return this.fechaHoraInicio;
        }
    }
}