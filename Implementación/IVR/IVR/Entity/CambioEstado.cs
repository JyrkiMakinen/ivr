using System;
namespace IVR.Entity
{
    public class CambioEstado
    {

        private DateTime fechaHoraInicio { get; set; }
        private DateTime fechaHoraFin { get; set; }
        private Estado estado { get; set; }

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        public bool esEstadoInicial()
        {
            return estado.esIniciada();
        }

        public bool esUltimoEstado()
        {
            return estado.esFinalizada();
        }

        public string getNombreEstado() {
            return estado.getNombre();
        }

        public DateTime getFechaHoraInicio() {
            return this.fechaHoraInicio;
        }
    }
}