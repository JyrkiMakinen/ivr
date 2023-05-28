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
            if (estado.esIniciada()) {
                return true;
            }
            return false;
        }

        public bool esUltimoEstado()
        {
            if (fechaHoraFin == null) {
                return true;
            }
            return false;
        }
    }
}