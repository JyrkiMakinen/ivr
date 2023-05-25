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
            // Implementación del método tieneEncuestasRespondidas
            // Aquí puedes agregar la lógica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el método está vacío y siempre devuelve false
            return false;
        }

        public bool esDePeriodo()
        {
            // Implementación del método esDePeriodo
            // Aquí puedes agregar la lógica que determine si la llamada está dentro de un período específico
            // Por ahora, el método está vacío y siempre devuelve false
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