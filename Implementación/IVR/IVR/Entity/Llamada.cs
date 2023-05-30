using System;
using System.Collections.Generic;

namespace IVR.Entity
{
    public class Llamada
    {
        private Cliente cliente;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private List<RespuestaDeCliente> respuestasCliente;
        private List<CambioEstado> cambiosDeEstado;
        private long id;

        public Llamada(long id, Cliente cliente, List<CambioEstado> cambiosDeEstado, List<RespuestaDeCliente> respuestasCliente, TimeSpan duracion, bool encuestaEnviada)
        {
            this.id = id;
            this.cliente = cliente;
            this.cambiosDeEstado = cambiosDeEstado;
            this.respuestasCliente = respuestasCliente;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
        }

        public bool tieneEncuestasRespondidas()
        {
            return respuestasCliente.Count > 0; 
        }

        public long getId() {
            return id;
        }

        public bool esDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo)
        {
            for (int i = 0; i < cambiosDeEstado.Count; i++) {
                if (cambiosDeEstado[i].esEstadoInicial()) {
                    if (cambiosDeEstado[i].getFechaHoraInicio() > fechaInicioPeriodo && cambiosDeEstado[i].getFechaHoraInicio() < fechaFinPeriodo) {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public DateTime getFechaHoraInicio()
        {
            foreach (CambioEstado cambioEstado in cambiosDeEstado)
            {
                if (cambioEstado.esEstadoInicial())
                {
                    return cambioEstado.getFechaHoraInicio();
                }
            }
            throw new Exception();
        }

        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }

        public string getEstadoActual()
        {
            for (int i = 0; i < cambiosDeEstado.Count; i++)
            {
                if (cambiosDeEstado[i].esUltimoEstado())
                {
                    return cambiosDeEstado[i].getNombreEstado();
                }
            }
            return "Not Found";
        }

        public List<RespuestaDeCliente> getRespuestas()
        {
           return respuestasCliente;
        }

        public TimeSpan getDuracion()
        {
            return duracion;
        }
    }
}