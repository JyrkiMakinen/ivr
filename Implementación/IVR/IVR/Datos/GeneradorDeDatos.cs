using IVR.Entity;

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
            Estado estado1 = new Estado("Iniciada", true);
            Estado estado2 = new Estado("Cancelada", false);
            Estado estado2 = new Estado("Finalizada", false);
            Estado estado2 = new Estado("EnCurso", false);

            estados = new List<Estado>() { estado1, estado2 };

            //cambioEstados


            //Clientes
            Cliente cliente1 = new Cliente("Pablo Rivadavia");
            Cliente cliente2 = new Cliente("Emanuel Sincero");
            Cliente cliente3 = new Cliente("Juan Pesquera");

            clientes = new List<Cliente>() { cliente1, cliente2, cliente3 };


            //Llamadas
            Llamada llamada1 = new Llamada() { cliente1 };
            Llamada llamada2 = new LLamada() { cliente2 };

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