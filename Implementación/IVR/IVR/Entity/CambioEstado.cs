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
            // Implementaci�n del m�todo tieneEncuestasRespondidas
            // Aqu� puedes agregar la l�gica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el m�todo est� vac�o y siempre devuelve false
            return false;
        }

        public bool esUltimoEstado()
        {

            return false;
        }

    }
}