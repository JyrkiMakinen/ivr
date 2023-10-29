using System;
using System.Collections.Generic;
using System.Data;

namespace IVR.Entity
{
    public class Llamada
    {
        private Cliente cliente;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private List<RespuestaDeCliente> respuestasCliente;
        private List<CambioEstado> cambiosDeEstado;

        public Llamada(Cliente cliente, List<CambioEstado> cambiosDeEstado, List<RespuestaDeCliente> respuestasCliente, TimeSpan duracion, bool encuestaEnviada)
        {
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

        public bool esDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo, out CambioEstado inicial)
        {
            inicial = null;
            for (int i = 0; i < cambiosDeEstado.Count; i++)
            {
                if (cambiosDeEstado[i].esEstadoIniciada())
                {
                    if (cambiosDeEstado[i].getFechaHoraInicio() > fechaInicioPeriodo && cambiosDeEstado[i].getFechaHoraInicio() < fechaFinPeriodo)
                    {
                        inicial = cambiosDeEstado[i];
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
            for (int i = 0; i < cambiosDeEstado.Count; i++)
            {
                if (cambiosDeEstado[i].esUltimoEstado())
                {
                    return cambiosDeEstado[i].getNombreEstado();
                }
            }
            return "Not Found";
        }

        public TimeSpan getDuracion()
        {
            return duracion;
        }

        public void obtenerPreguntasYRespuestas(ref DataTable preguntasYrespuestas, ref string descripcionEncuesta, List<Pregunta> allPreguntas, List<Encuesta> allEncuestas)
        {
            foreach (RespuestaDeCliente respCli in respuestasCliente)
            {
                respCli.obtenerDescripcionRta(ref preguntasYrespuestas, ref descripcionEncuesta, allPreguntas, allEncuestas);
            }
        }
    }
}