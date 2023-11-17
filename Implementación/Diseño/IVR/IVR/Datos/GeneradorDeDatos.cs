using IVR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IVR.Datos
{
    public class GeneradorDeDatos
    {
        // Atributos: todas las listas de todos los datos del sistema
        public List<Estado> estados;
        public List<CambioEstado> cambioEstados;
        public List<Cliente> clientes;
        public List<Encuesta> encuestas;
        public List<Llamada> llamadas;
        public List<Pregunta> preguntas;
        public List<RespuestaPosible> respuestasPosibles;
        public List<RespuestaDeCliente> respuestasDeCliente;

        // Método constructor. Genera todos los datos y los guarda en las listas.
        public GeneradorDeDatos()
        {
            // NUEVO
            // DbContext
            IVRDbContext context = new IVRDbContext();

            // Eager loading
            estados = context.Estados.ToList();
            cambioEstados = context.CambioEstados.ToList();
            clientes = context.Clientes.ToList();
            encuestas = context.Encuestas.ToList();
            llamadas = context.Llamadas.ToList();
            preguntas = context.Preguntas.ToList();
            respuestasPosibles = context.RespuestaPosibles.ToList();
            respuestasDeCliente = context.RespuestasDeClientes.ToList();
        }

        public List<Estado> getEstados() { return estados; }
        public List<CambioEstado> getCambioEstados() { return cambioEstados; }
        public List<Cliente> getClientes() { return clientes; }
        public List<Encuesta> getEncuestas() { return encuestas; }
        public List<Llamada> getLlamadas() { return llamadas; }
        public List<Pregunta> getPreguntas() { return preguntas; }
        public List<RespuestaPosible> getRespuestasPosibles() { return respuestasPosibles; }
        public List<RespuestaDeCliente> getRespuestasDeCliente() { return respuestasDeCliente; }
    }
}