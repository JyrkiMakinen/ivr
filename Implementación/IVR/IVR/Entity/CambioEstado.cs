namespace IVR.Entity
{
    public class CambioEstado
    {

        private DateTime fechaHoraInicio { get; set; }
        private Estado estado { get; set; }

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        public bool esEstadoInicial()
        {
            // Implementación del método tieneEncuestasRespondidas
            // Aquí puedes agregar la lógica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el método está vacío y siempre devuelve false
            return false;
        }

        public bool esUltimoEstado()
        {

            return false;
        }

    }
}