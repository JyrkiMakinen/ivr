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

        public bool esEstadoIniciada()
        {
            return estado.esIniciada();
        }

        public DateTime getFechaHoraInicio()
        {
            return fechaHoraInicio;
        }

        public bool esUltimoEstado()
        {
            if (fechaHoraFin == null)
            {
                return true;
            }
            return false;
        }

        public string getNombreEstado()
        {
            return estado.getNombre();
        }

    }
}