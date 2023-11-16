using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace IVR.Entity
{
    public class Llamada
    {
        // Atributos
        [Key]
        public int LlamadaId { get; set; }

        [ForeignKey("Cliente")]
        public int? ClienteId { get; set; } // Fabricacion pura
        public Cliente Cliente { get; set; }

        public TimeSpan Duracion { get; set; }

        public bool EncuestaEnviada { get; set; }

        public List<RespuestaDeCliente> RespuestaDeClientes { get; set; }

        public List<CambioEstado> CambioEstados { get; set; }


        // Metodos
        public Llamada(Cliente cliente, List<CambioEstado> cambiosDeEstado, List<RespuestaDeCliente> respuestasCliente, TimeSpan duracion, bool encuestaEnviada)
        {
            this.Cliente = cliente;
            this.CambioEstados = cambiosDeEstado;
            this.RespuestaDeClientes = respuestasCliente;
            this.Duracion = duracion;
            this.EncuestaEnviada = encuestaEnviada;
        }

        public bool tieneEncuestasRespondidas()
        {
            return RespuestaDeClientes.Count > 0; 
        }

        public bool esDePeriodo(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo, out CambioEstado inicial)
        {
            inicial = null;
            for (int i = 0; i < CambioEstados.Count; i++)
            {
                if (CambioEstados[i].esEstadoIniciada())
                {
                    if (CambioEstados[i].getFechaHoraInicio() > fechaInicioPeriodo && CambioEstados[i].getFechaHoraInicio() < fechaFinPeriodo)
                    {
                        inicial = CambioEstados[i];
                        return true;
                    }
                }
            }

            return false;
        }

        public string getNombreClienteDeLlamada()
        {
            return Cliente.getNombre();
        }

        public string getEstadoActual()
        {
            for (int i = 0; i < CambioEstados.Count; i++)
            {
                if (CambioEstados[i].esUltimoEstado())
                {
                    return CambioEstados[i].getNombreEstado();
                }
            }
            return "Not Found";
        }

        public TimeSpan getDuracion()
        {
            return Duracion;
        }

        public void obtenerPreguntasYRespuestas(ref DataTable preguntasYrespuestas, ref string descripcionEncuesta, List<Pregunta> allPreguntas, List<Encuesta> allEncuestas)
        {
            foreach (RespuestaDeCliente respCli in RespuestaDeClientes)
            {
                respCli.obtenerDescripcionRta(ref preguntasYrespuestas, ref descripcionEncuesta, allPreguntas, allEncuestas);
            }
        }
    }
}