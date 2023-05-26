namespace IVR.Entity
{
    public class Llamada
    {
        private List<CambioDeEstado> cambioDeEstado;
        private CambioDeEstado ultimoCambioEstado;
        private Cliente cliente;

        public Llamada(Cliente cliente)
        {
            Estado estado = new Estado("Iniciada");
            CambioDeEstado cambioDeEstado1 = new CambioDeEstado(new DateTime(), estado);

            cambioDeEstado = new List<CambioDeEstado> { cambioDeEstado1 };
            this.cliente = cliente;
        }

        public bool tieneEncuestasRespondidas()
        {
            // Implementaci�n del m�todo tieneEncuestasRespondidas
            // Aqu� puedes agregar la l�gica que determine si la llamada tiene encuestas respondidas
            // Por ahora, el m�todo est� vac�o y siempre devuelve false
            return false;
        }

        public bool esDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            
            for (int i = 0; i < cambioDeEstado.Count(); i++) {
                if (cambioDeEstado[i].esEstadoInicial()) {
                    if (cambioDeEstado[i].getFechaHoraInicio() > fechaInicioPeriodo && cambioDeEstado[i].getFechaHoraInicio()) {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }

        public string getEstadoActual()
        {
            for (int i = 0; i < cambioDeEstado.Count(); i++)
            {
                if (cambioDeEstado[i].esUltimoEstado())
                {
                    this.ultimoCambioEstado = cambioDeEstado[i].getNombre();
                    return ultimoCambioEstado;
                }
            }
        }

        public long getDuration()
        {
            return ultimoCambioEstado.getFechaHoraInicio() - ultimoCambioEstado.getFechaHoraFin();
        }

        public void getRespuestas()
        {


        }
    }
}