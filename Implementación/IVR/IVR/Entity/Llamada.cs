using System;
namespace IVR.Entity
{
    public class Llamada
    {
        private List<CambioDeEstado> cambioDeEstado;
        private CambioDeEstado ultimoCambioEstado;
        private Cliente cliente;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private List<RespuestaDeCliente> respuestasDeCliente;

        public Llamada(Cliente cliente)
        {
            Estado estado = new Estado("Iniciada");
            CambioDeEstado cambioDeEstado1 = new CambioDeEstado(new DateTime(), estado);

            cambiosDeEstado = new List<CambioDeEstado> { cambioDeEstado1 };
            this.cliente = cliente;
            this.encuestaEnviada = true; // hardcodeado en true para simular encuesta respondida, pero deberia inicializarse en false
        }

        public bool tieneEncuestasRespondidas()
        {
            return respuestasDeCliente.Count() > 0; 
        }

        public bool esDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            for (int i = 0; i < cambiosDeEstado.Count(); i++) {
                if (cambiosDeEstado[i].esEstadoInicial()) {
                    if (cambiosDeEstado[i].getFechaHoraInicio() > fechaInicioPeriodo && cambiosDeEstado[i].getFechaHoraInicio() < fechaFinPeriodo) {
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
            for (int i = 0; i < cambiosDeEstado.Count(); i++)
            {
                if (cambiosDeEstado[i].esUltimoEstado())
                {
                    this.ultimoCambioEstado = cambiosDeEstado[i].getNombreEstado();

                    return ultimoCambioEstado;
                }
            }
        }

        public TimeSpan calcularDuracion()
        {
            DateTime fechaHoraInicio;
            DateTime fechaHoraFin;

            for (int i = 0; i < cambiosDeEstado.Count(); i++) {
                if (cambiosDeEstado[i].esEstadoInicial()) {
                    fechaHoraInicio = cambiosDeEstado[i].getFechaHoraInicio(); // Obtiene la fecha y hora inicio a partir de la cual se seteo en estado Iniciada
                }

                if (cambiosDeEstado[i].esUltimoEstado()) {
                    fechaHoraFin = cambiosDeEstado[i].getFechaHoraInicio() // Obtiene la fecha y hora inicio a partir de la cual se seteo en estado Finalizada
                }
            }

            duracion = fechaHoraFin - fechaHoraInicio; // La diferencia entre dos objetos DateTime resulta en un objeto TimeSpan

            return duracion;
        }

        public void getRespuestas() // Que deberia devolver? Un arreglo con todos los datos?
        {
            this.respuestaCliente = respuestaDeCliente.obtenerDescripcionRta();
            this.descripcionPregunta = respuestaCliente.obtenerDescripcionPregunta();
            this.descripcionEncuesta = respuestaCliente.obtenerDescripcionEncuesta();
        }
    }
}