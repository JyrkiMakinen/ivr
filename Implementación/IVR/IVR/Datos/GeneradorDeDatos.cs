using IVR.Entity;
using System;
using System.Collections.Generic;

namespace IVR.Datos
{
    public class GeneradorDeDatos
    {
        //Atributos: todas las listas de todos los datos del sistema
        private List<Estado> estados;
        private List<CambioEstado> cambioEstados;
        private List<Cliente> clientes;
        private List<Encuesta> encuentas;
        private List<Llamada> llamadas;
        private List<Pregunta> preguntas;
        private List<RespuestaPosible> respuestasPosibles;


        public GeneradorDeDatos() {
            //Estados
            Estado estadoIniciada = new Estado("Iniciada");
            Estado estadoCancelada = new Estado("Cancelada");
            Estado estadoEncurso = new Estado("EnCurso");
            Estado estadoFinalizada = new Estado("Finalizada");

            estados = new List<Estado>() { estadoIniciada, estadoCancelada };

            //cambioEstados
            CambioEstado cambioEstado1 = new CambioEstado(new DateTime(2023, 5, 25, 10, 40, 00), estadoIniciada);
            CambioEstado cambioEstado2 = new CambioEstado(new DateTime(2023, 5, 25, 10, 50, 00), estadoEncurso);
            CambioEstado cambioEstado3 = new CambioEstado(new DateTime(2023, 5, 25, 11, 05, 00), estadoFinalizada);

            cambioEstados = new List<CambioEstado>() { cambioEstado1, cambioEstado2, cambioEstado3 };


            //Clientes
            Cliente cliente1 = new Cliente("Pablo Rivadavia");
            Cliente cliente2 = new Cliente("Emanuel Sincero");
            Cliente cliente3 = new Cliente("Juan Pesquera");

            clientes = new List<Cliente>() { cliente1, cliente2, cliente3 };


            //Llamadas
            Llamada llamada1 = new Llamada() { cliente1 };
            Llamada llamada2 = new Llamada() { cliente2 };

            llamadas = new List<Llamada>() { llamada1, llamada2};

        }
        
        public List<Estado> getEstados() { return this.getEstados(); }
        public List<CambioEstado> getCambioEstados() { return this.cambioEstados(); }
        public List<Cliente> getClientes() { return this.clientes(); }
        public List<Encuesta> getEncuentas() { return this.encuentas(); }
        public List<Llamada> getLlamadas() { return this.llamadas(); }
        public List<Pregunta> getPreguntas() { return this.preguntas(); }
        public List<RespuestaPosible> getRespuestasPosibles() { return this.respuestasPosibles; }
    }
}