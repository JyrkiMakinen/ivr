using IVR.Entity;
using System;
using System.Collections.Generic;

namespace IVR.Datos
{
    public class GeneradorDeDatos
    {
        // Atributos: todas las listas de todos los datos del sistema
        private List<Estado> estados;
        private List<CambioEstado> cambioEstados;
        private List<Cliente> clientes;
        private List<Encuesta> encuentas;
        private List<Llamada> llamadas;
        private List<Pregunta> preguntas;
        private List<RespuestaPosible> respuestasPosibles;

        // Método constructor. Genera todos los datos y los a guarda en las listas.
        public GeneradorDeDatos() {

            //Estados
            Estado iniciada = new Estado("Iniciada");
            Estado cancelada = new Estado("Cancelada");
            Estado enCurso = new Estado("EnCurso");
            Estado finalizada = new Estado("Finalizada");

            estados = new List<Estado>() { iniciada, cancelada, enCurso, finalizada };

            //CambioEstados
            //Constructor fecha: new DateTime(year, month, day, hour, min, seconds)

            CambioEstado cambioEstado1 = new CambioEstado(new DateTime(2023, 1, 25, 10, 40, 00), iniciada);
            CambioEstado cambioEstado2 = new CambioEstado(new DateTime(2023, 1, 25, 10, 40, 56), enCurso);
            CambioEstado cambioEstado3 = new CambioEstado(new DateTime(2023, 1, 25, 10, 41, 21), finalizada);

            CambioEstado cambioEstado4 = new CambioEstado(new DateTime(2023, 1, 29, 05, 00, 51), iniciada);
            CambioEstado cambioEstado5 = new CambioEstado(new DateTime(2023, 1, 29, 05, 02, 01), cancelada);

            CambioEstado cambioEstado6 = new CambioEstado(new DateTime(2023, 2, 13, 01, 05, 01), iniciada);
            CambioEstado cambioEstado7 = new CambioEstado(new DateTime(2023, 2, 13, 01, 05, 50), enCurso);
            CambioEstado cambioEstado8 = new CambioEstado(new DateTime(2023, 2, 13, 01, 06, 50), finalizada);

            CambioEstado cambioEstado9 = new CambioEstado(new DateTime(2023, 2, 15, 11, 05, 34), iniciada);
            CambioEstado cambioEstado10 = new CambioEstado(new DateTime(2023, 2, 15, 11, 05, 53), enCurso);
            CambioEstado cambioEstado11 = new CambioEstado(new DateTime(2023, 2, 15, 11, 06, 13), cancelada);

            CambioEstado cambioEstado12 = new CambioEstado(new DateTime(2023, 2, 22, 14, 35, 03), iniciada);
            CambioEstado cambioEstado13 = new CambioEstado(new DateTime(2023, 2, 22, 14, 35, 57), finalizada);

            CambioEstado cambioEstado14 = new CambioEstado(new DateTime(2023, 2, 23, 18, 06, 04), iniciada);
            CambioEstado cambioEstado15 = new CambioEstado(new DateTime(2023, 2, 23, 18, 06, 59), finalizada);

            CambioEstado cambioEstado16 = new CambioEstado(new DateTime(2023, 3, 01, 16, 13, 40), iniciada);
            CambioEstado cambioEstado17 = new CambioEstado(new DateTime(2023, 3, 01, 16, 15, 53), cancelada);

            CambioEstado cambioEstado18 = new CambioEstado(new DateTime(2023, 3, 04, 19, 53, 04), iniciada);
            CambioEstado cambioEstado19 = new CambioEstado(new DateTime(2023, 3, 04, 19, 53, 43), enCurso);
            CambioEstado cambioEstado20 = new CambioEstado(new DateTime(2023, 3, 04, 19, 57, 15), finalizada);

            CambioEstado cambioEstado21 = new CambioEstado(new DateTime(2023, 3, 09, 04, 05, 56), iniciada);
            CambioEstado cambioEstado22 = new CambioEstado(new DateTime(2023, 3, 09, 04, 06, 34), finalizada);

            CambioEstado cambioEstado23 = new CambioEstado(new DateTime(2023, 3, 15, 23, 45, 26), iniciada);
            CambioEstado cambioEstado24 = new CambioEstado(new DateTime(2023, 3, 15, 23, 46, 18), finalizada);

            CambioEstado cambioEstado25 = new CambioEstado(new DateTime(2023, 4, 06, 15, 14, 28), iniciada);
            CambioEstado cambioEstado26 = new CambioEstado(new DateTime(2023, 4, 06, 15, 16, 48), cancelada);

            CambioEstado cambioEstado27 = new CambioEstado(new DateTime(2023, 4, 10, 07, 30, 27), iniciada);
            CambioEstado cambioEstado28 = new CambioEstado(new DateTime(2023, 4, 10, 07, 30, 43), enCurso);
            CambioEstado cambioEstado29 = new CambioEstado(new DateTime(2023, 4, 10, 07, 38, 00), cancelada);

            CambioEstado cambioEstado30 = new CambioEstado(new DateTime(2023, 4, 18, 08, 59, 26), iniciada);
            CambioEstado cambioEstado31 = new CambioEstado(new DateTime(2023, 4, 18, 09, 00, 11), finalizada);

            CambioEstado cambioEstado32 = new CambioEstado(new DateTime(2023, 5, 02, 21, 23, 48), iniciada);
            CambioEstado cambioEstado33 = new CambioEstado(new DateTime(2023, 5, 02, 21, 25, 58), finalizada);

            CambioEstado cambioEstado34 = new CambioEstado(new DateTime(2023, 5, 12, 22, 46, 26), iniciada);
            CambioEstado cambioEstado35 = new CambioEstado(new DateTime(2023, 5, 12, 22, 47, 24), enCurso);
            CambioEstado cambioEstado36 = new CambioEstado(new DateTime(2023, 5, 12, 22, 51, 37), finalizada);

            CambioEstado cambioEstado37 = new CambioEstado(new DateTime(2023, 5, 23, 10, 41, 57), iniciada);
            CambioEstado cambioEstado38 = new CambioEstado(new DateTime(2023, 5, 23, 10, 50, 25), finalizada);

            CambioEstado cambioEstado39 = new CambioEstado(new DateTime(2023, 5, 27, 12, 33, 45), iniciada);
            CambioEstado cambioEstado40 = new CambioEstado(new DateTime(2023, 5, 27, 12, 35, 52), finalizada);

            cambioEstados = new List<CambioEstado>() { cambioEstado1, cambioEstado2, cambioEstado3, cambioEstado4, cambioEstado5, cambioEstado6, cambioEstado7, cambioEstado8, cambioEstado9, cambioEstado10, cambioEstado11, cambioEstado12, cambioEstado13, cambioEstado14, cambioEstado15, cambioEstado16, cambioEstado17, cambioEstado18, cambioEstado19, cambioEstado20, cambioEstado21, cambioEstado22,cambioEstado23,cambioEstado24,cambioEstado25,cambioEstado26,cambioEstado27,cambioEstado28,cambioEstado29,cambioEstado30,cambioEstado31,cambioEstado32,cambioEstado33,cambioEstado34,cambioEstado35,cambioEstado36,cambioEstado37,cambioEstado38,cambioEstado39,cambioEstado40 };


            //Clientes
            Cliente cliente1 = new Cliente("Pablo Rivadavia");
            Cliente cliente2 = new Cliente("Emanuel Sincero");
            Cliente cliente3 = new Cliente("Juan Pesquera");
            Cliente cliente4 = new Cliente("Mauricio Basta");
            Cliente cliente5 = new Cliente("Nicolás Domínguez");
            Cliente cliente6 = new Cliente("Mauricio Basta");
            Cliente cliente7 = new Cliente("Bruno Toledo");
            Cliente cliente8 = new Cliente("Alexis Carnero");
            Cliente cliente9 = new Cliente("Débora Avram");
            Cliente cliente10 = new Cliente("Kalil Zahr");
            Cliente cliente11 = new Cliente("Agustín Caviglia");
            Cliente cliente12 = new Cliente("Mickaela Crespo");
            Cliente cliente13 = new Cliente("Valeria Abdala");
            Cliente cliente14 = new Cliente("Elízabeth Jeinson");
            Cliente cliente15 = new Cliente("Mauro Bastasini");
            Cliente cliente16 = new Cliente("Inés Haefeli");
            Cliente cliente17 = new Cliente("Judith Meles");

            clientes = new List<Cliente>() { cliente1, cliente2, cliente3, cliente4, cliente5, cliente6, cliente7, cliente8, cliente9, cliente10, cliente11, cliente12, cliente13, cliente14, cliente15, cliente16, cliente17};


            //RespuestasPosibles
            RespuestaPosible respPos1 = new RespuestaPosible("Puntaje 1/5", 1);
            RespuestaPosible respPos2 = new RespuestaPosible("Puntaje 2/5", 2);
            RespuestaPosible respPos3 = new RespuestaPosible("Puntaje 3/5", 3);
            RespuestaPosible respPos4 = new RespuestaPosible("Puntaje 4/5", 4);
            RespuestaPosible respPos5 = new RespuestaPosible("Puntaje 5/5", 5);
            RespuestaPosible respPos6 = new RespuestaPosible("Sí", 1);
            RespuestaPosible respPos7 = new RespuestaPosible("No", 2);
            RespuestaPosible respPos8 = new RespuestaPosible("Más o menos", 3);
            RespuestaPosible respPos9 = new RespuestaPosible("No sé", 4);
            List<RespuestaPosible> puntajes = new List<RespuestaPosible>() { respPos1, respPos2, respPos3, respPos4, respPos5 };
            List<RespuestaPosible> siYno = new List<RespuestaPosible>() { respPos6, respPos7 };
            List<RespuestaPosible> siYno_extras = new List<RespuestaPosible>() { respPos6, respPos7, respPos8, respPos9 };

            respuestasPosibles = new List<RespuestaPosible>() { respPos1,respPos2,respPos3,respPos4,respPos5,respPos6,respPos7,respPos8,respPos9 };


            //Preguntas
            Pregunta pregunta1 = new Pregunta("Califique la atención con un puntaje del 1 al 5.", puntajes);
            Pregunta pregunta2 = new Pregunta("¿Se siente conforme con la ayuda brindada?", siYno_extras);
            Pregunta pregunta3 = new Pregunta("¿Su problema fue solucionado?", siYno);
            Pregunta pregunta4 = new Pregunta("¿La voz del operador se escuchaba correctamente?", siYno_extras);
            Pregunta pregunta5 = new Pregunta("Califique el sistema de respuestas interactivas con un puntaje del 1 al 5.", puntajes);
            Pregunta pregunta6 = new Pregunta("¿El operador atendió en un tiempo razonable?", siYno_extras);
            Pregunta pregunta7 = new Pregunta("¿El trato del operador fue adecuado?", siYno_extras);
            List<Pregunta> preguntasOperador = new List<Pregunta>() { pregunta1, pregunta4, pregunta6, pregunta7 };
            List<Pregunta> preguntasSistema = new List<Pregunta>() { pregunta2, pregunta3, pregunta5 };

            preguntas = new List<Pregunta>() { pregunta1,pregunta2,pregunta3,pregunta4,pregunta5,pregunta6,pregunta7 };


            //RespuestasDeCliente




            //Encuestas
            Encuesta encuesta1 = new Encuesta("Encuesta sobre operador.", preguntasOperador, new DateTime(2023, 12, 31, 23, 59, 59));
            Encuesta encuesta2 = new Encuesta("Encuesta sobre sistema.", preguntasSistema, new DateTime(2022, 12, 31, 23, 59, 59));

            encuestas = new List<Encuesta>() { encuesta1,encuesta2 };

            //Llamadas
            Llamada llamada1 = new Llamada();

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