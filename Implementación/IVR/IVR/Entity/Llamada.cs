namespace IVR.Entity
{
    public class Llamada
    {
        private CambioDeEstado cambioDeEstado;
        private Cliente cliente;

        public Llamada(Cliente cliente)
        {
            Estado estado = new Estado("Iniciada");
            cambioDeEstado = new CambioDeEstado(new DateTime(), estado);
            this.cliente = cliente;
        }

        public bool tieneEncuestasRespondidas()
        {
            // Implementaci�n del m�todo tieneEncuestasRespondidas
            // Aqu� puedes agregar la l�gica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el m�todo est� vac�o y siempre devuelve false
            return false;
        }

        public bool esDePeriodo()
        {
            // Implementaci�n del m�todo esDePeriodo
            // Aqu� puedes agregar la l�gica que determine si la llamada est� dentro de un per�odo espec�fico
            // Por ahora, el m�todo est� vac�o y siempre devuelve false
            return false;
        }

        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }

        public string getEstadoActual()
        {
            Estado esUltimoEstado = cambioDeEstado.esUltimoEstado();
            return esUltimoEstado.getNombre();
        }

        public long getDuration()
        {

            return 1L;
        }

        public void getRespuesta()
        {


        }
    }
}