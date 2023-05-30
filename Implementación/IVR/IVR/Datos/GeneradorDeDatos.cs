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
        private List<Encuesta> encuestas;
        private List<Llamada> llamadas;
        private List<Pregunta> preguntas;
        private List<RespuestaPosible> respuestasPosibles;
        private List<RespuestaDeCliente> respuestasDeCliente;

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
            List<CambioEstado> ce_llamada1 = new List<CambioEstado>() { cambioEstado1, cambioEstado2, cambioEstado3 }; // CambiosEstado para la llamada i

            CambioEstado cambioEstado4 = new CambioEstado(new DateTime(2023, 1, 29, 05, 00, 51), iniciada);
            CambioEstado cambioEstado5 = new CambioEstado(new DateTime(2023, 1, 29, 05, 02, 01), cancelada);
            List<CambioEstado> ce_llamada2 = new List<CambioEstado>() { cambioEstado4, cambioEstado5 };

            CambioEstado cambioEstado6 = new CambioEstado(new DateTime(2023, 2, 13, 01, 05, 01), iniciada);
            CambioEstado cambioEstado7 = new CambioEstado(new DateTime(2023, 2, 13, 01, 05, 50), enCurso);
            CambioEstado cambioEstado8 = new CambioEstado(new DateTime(2023, 2, 13, 01, 06, 50), finalizada);
            List<CambioEstado> ce_llamada3 = new List<CambioEstado>() { cambioEstado6, cambioEstado7, cambioEstado8 };

            CambioEstado cambioEstado9 = new CambioEstado(new DateTime(2023, 2, 15, 11, 05, 34), iniciada);
            CambioEstado cambioEstado10 = new CambioEstado(new DateTime(2023, 2, 15, 11, 05, 53), enCurso);
            CambioEstado cambioEstado11 = new CambioEstado(new DateTime(2023, 2, 15, 11, 06, 13), cancelada);
            List<CambioEstado> ce_llamada4 = new List<CambioEstado>() { cambioEstado9, cambioEstado10, cambioEstado11 };

            CambioEstado cambioEstado12 = new CambioEstado(new DateTime(2023, 2, 22, 14, 35, 03), iniciada);
            CambioEstado cambioEstado13 = new CambioEstado(new DateTime(2023, 2, 22, 14, 35, 57), finalizada);
            List<CambioEstado> ce_llamada5 = new List<CambioEstado>() { cambioEstado12, cambioEstado13 };

            CambioEstado cambioEstado14 = new CambioEstado(new DateTime(2023, 2, 23, 18, 06, 04), iniciada);
            CambioEstado cambioEstado15 = new CambioEstado(new DateTime(2023, 2, 23, 18, 06, 59), finalizada);
            List<CambioEstado> ce_llamada6 = new List<CambioEstado>() { cambioEstado14, cambioEstado15 };

            CambioEstado cambioEstado16 = new CambioEstado(new DateTime(2023, 3, 01, 16, 13, 40), iniciada);
            CambioEstado cambioEstado17 = new CambioEstado(new DateTime(2023, 3, 01, 16, 15, 53), cancelada);
            List<CambioEstado> ce_llamada7 = new List<CambioEstado>() { cambioEstado16, cambioEstado17 };

            CambioEstado cambioEstado18 = new CambioEstado(new DateTime(2023, 3, 04, 19, 53, 04), iniciada);
            CambioEstado cambioEstado19 = new CambioEstado(new DateTime(2023, 3, 04, 19, 53, 43), enCurso);
            CambioEstado cambioEstado20 = new CambioEstado(new DateTime(2023, 3, 04, 19, 57, 15), finalizada);
            List<CambioEstado> ce_llamada8 = new List<CambioEstado>() { cambioEstado18, cambioEstado19, cambioEstado20 };

            CambioEstado cambioEstado21 = new CambioEstado(new DateTime(2023, 3, 09, 04, 05, 56), iniciada);
            CambioEstado cambioEstado22 = new CambioEstado(new DateTime(2023, 3, 09, 04, 06, 34), finalizada);
            List<CambioEstado> ce_llamada9 = new List<CambioEstado>() { cambioEstado21, cambioEstado22 };

            CambioEstado cambioEstado23 = new CambioEstado(new DateTime(2023, 3, 15, 23, 45, 26), iniciada);
            CambioEstado cambioEstado24 = new CambioEstado(new DateTime(2023, 3, 15, 23, 46, 18), finalizada);
            List<CambioEstado> ce_llamada10 = new List<CambioEstado>() { cambioEstado23, cambioEstado24 };

            CambioEstado cambioEstado25 = new CambioEstado(new DateTime(2023, 4, 06, 15, 14, 28), iniciada);
            CambioEstado cambioEstado26 = new CambioEstado(new DateTime(2023, 4, 06, 15, 16, 48), cancelada);
            List<CambioEstado> ce_llamada11 = new List<CambioEstado>() { cambioEstado25, cambioEstado26 };

            CambioEstado cambioEstado27 = new CambioEstado(new DateTime(2023, 4, 10, 07, 30, 27), iniciada);
            CambioEstado cambioEstado28 = new CambioEstado(new DateTime(2023, 4, 10, 07, 30, 43), enCurso);
            CambioEstado cambioEstado29 = new CambioEstado(new DateTime(2023, 4, 10, 07, 38, 00), cancelada);
            List<CambioEstado> ce_llamada12 = new List<CambioEstado>() { cambioEstado27, cambioEstado28, cambioEstado29 };

            CambioEstado cambioEstado30 = new CambioEstado(new DateTime(2023, 4, 18, 08, 59, 26), iniciada);
            CambioEstado cambioEstado31 = new CambioEstado(new DateTime(2023, 4, 18, 09, 00, 11), finalizada);
            List<CambioEstado> ce_llamada13 = new List<CambioEstado>() { cambioEstado30, cambioEstado31 };

            CambioEstado cambioEstado32 = new CambioEstado(new DateTime(2023, 5, 02, 21, 23, 48), iniciada);
            CambioEstado cambioEstado33 = new CambioEstado(new DateTime(2023, 5, 02, 21, 25, 58), finalizada);
            List<CambioEstado> ce_llamada14 = new List<CambioEstado>() { cambioEstado32, cambioEstado33 };

            CambioEstado cambioEstado34 = new CambioEstado(new DateTime(2023, 5, 12, 22, 46, 26), iniciada);
            CambioEstado cambioEstado35 = new CambioEstado(new DateTime(2023, 5, 12, 22, 47, 28), enCurso);
            CambioEstado cambioEstado36 = new CambioEstado(new DateTime(2023, 5, 12, 22, 51, 37), finalizada);
            List<CambioEstado> ce_llamada15 = new List<CambioEstado>() { cambioEstado34, cambioEstado35, cambioEstado36 };

            CambioEstado cambioEstado37 = new CambioEstado(new DateTime(2023, 5, 23, 10, 41, 57), iniciada);
            CambioEstado cambioEstado38 = new CambioEstado(new DateTime(2023, 5, 23, 10, 50, 25), finalizada);
            List<CambioEstado> ce_llamada16 = new List<CambioEstado>() { cambioEstado37, cambioEstado38 };

            CambioEstado cambioEstado39 = new CambioEstado(new DateTime(2023, 5, 27, 12, 33, 45), iniciada);
            CambioEstado cambioEstado40 = new CambioEstado(new DateTime(2023, 5, 27, 12, 35, 52), finalizada);
            List<CambioEstado> ce_llamada17 = new List<CambioEstado>() { cambioEstado39, cambioEstado40 };

            cambioEstados = new List<CambioEstado>() { cambioEstado1, cambioEstado2, cambioEstado3, cambioEstado4, cambioEstado5, cambioEstado6, cambioEstado7, cambioEstado8, cambioEstado9, cambioEstado10, cambioEstado11, cambioEstado12, cambioEstado13, cambioEstado14, cambioEstado15, cambioEstado16, cambioEstado17, cambioEstado18, cambioEstado19, cambioEstado20, cambioEstado21, cambioEstado22,cambioEstado23,cambioEstado24,cambioEstado25,cambioEstado26,cambioEstado27,cambioEstado28,cambioEstado29,cambioEstado30,cambioEstado31,cambioEstado32,cambioEstado33,cambioEstado34,cambioEstado35,cambioEstado36,cambioEstado37,cambioEstado38,cambioEstado39,cambioEstado40 };


            //Clientes
            Cliente cliente1 = new Cliente("Pablo Rivadavia"); // Cliente para la llamada i
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
            RespuestaPosible respPosPunt1 = new RespuestaPosible("Puntaje 1/5", 1);
            RespuestaPosible respPosPunt2 = new RespuestaPosible("Puntaje 2/5", 2);
            RespuestaPosible respPosPunt3 = new RespuestaPosible("Puntaje 3/5", 3);
            RespuestaPosible respPosPunt4 = new RespuestaPosible("Puntaje 4/5", 4);
            RespuestaPosible respPosPunt5 = new RespuestaPosible("Puntaje 5/5", 5);
            List<RespuestaPosible> respuestasPosiblesPuntaje = new List<RespuestaPosible>() { respPosPunt1,respPosPunt2,respPosPunt3,respPosPunt4,respPosPunt5 }; // RespuestasPosibles para pregunta i

            RespuestaPosible respPosProblema1 = new RespuestaPosible("Sí", 1);
            RespuestaPosible respPosProblema2 = new RespuestaPosible("No", 2);
            List<RespuestaPosible> respuestasPosiblesProblema = new List<RespuestaPosible>() { respPosProblema1, respPosProblema2 };

            RespuestaPosible respPosVoz1 = new RespuestaPosible("Muy clara", 1);
            RespuestaPosible respPosVoz2 = new RespuestaPosible("Bastante clara", 2);
            RespuestaPosible respPosVoz3 = new RespuestaPosible("Poco clara", 3);
            RespuestaPosible respPosVoz4 = new RespuestaPosible("Para nada clara", 4);
            RespuestaPosible respPosVoz5 = new RespuestaPosible("No conversé con un operador", 5);
            List<RespuestaPosible> respuestasPosiblesVoz = new List<RespuestaPosible>() { respPosVoz1, respPosVoz2, respPosVoz3, respPosVoz4 };

            RespuestaPosible respPosTiempo1 = new RespuestaPosible("Menos de 1 minuto", 1);
            RespuestaPosible respPosTiempo2 = new RespuestaPosible("Entre 1 y 5 minutos", 2);
            RespuestaPosible respPosTiempo3 = new RespuestaPosible("Más de 5 minutos", 3);
            RespuestaPosible respPosTiempo4 = new RespuestaPosible("No contestó", 4);
            RespuestaPosible respPosTiempo5 = new RespuestaPosible("No intenté hablar con uno", 5);
            List<RespuestaPosible> respuestasPosiblesTiempo = new List<RespuestaPosible>() { respPosTiempo1, respPosTiempo2, respPosTiempo3 };

            RespuestaPosible respPosSistema1 = new RespuestaPosible("Excelente", 1);
            RespuestaPosible respPosSistema2 = new RespuestaPosible("Bueno", 2);
            RespuestaPosible respPosSistema3 = new RespuestaPosible("Malo", 3);
            List<RespuestaPosible> respuestasPosiblesSistema = new List<RespuestaPosible>() { respPosSistema1, respPosSistema2, respPosSistema3 };

            respuestasPosibles = new List<RespuestaPosible>() { respPosPunt1, respPosPunt2, respPosPunt3, respPosPunt4, respPosPunt5, respPosProblema1, respPosProblema2, respPosVoz1, respPosVoz2, respPosVoz3, respPosVoz4, respPosVoz5, respPosTiempo1, respPosTiempo2, respPosTiempo3, respPosSistema1, respPosSistema2, respPosSistema3 };


            //Preguntas
            Pregunta pregunta1 = new Pregunta("Califique la atención con un puntaje del 1 al 5.", respuestasPosiblesPuntaje);
            Pregunta pregunta2 = new Pregunta("¿Su problema fue solucionado?", respuestasPosiblesProblema);
            Pregunta pregunta3 = new Pregunta("¿Cómo se escuchaba la voz del operador?", respuestasPosiblesVoz);
            Pregunta pregunta4 = new Pregunta("¿Cuánto tardó el operador en contestar?", respuestasPosiblesTiempo);
            Pregunta pregunta5 = new Pregunta("¿Qué le pareció el nuevo sistema IVR?", respuestasPosiblesSistema);

            preguntas = new List<Pregunta>() { pregunta1,pregunta2,pregunta3,pregunta4,pregunta5 };


            //RespuestasDeCliente
            RespuestaDeCliente resp1_llamada1 = new RespuestaDeCliente(respPosPunt4);
            RespuestaDeCliente resp2_llamada1 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada1 = new RespuestaDeCliente(respPosVoz1);
            RespuestaDeCliente resp4_llamada1 = new RespuestaDeCliente(respPosTiempo1);
            RespuestaDeCliente resp5_llamada1 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas1 = new List<RespuestaDeCliente>() { resp1_llamada1,resp2_llamada1,resp3_llamada1,resp4_llamada1,resp5_llamada1}; //RespuestasDeCliente para llamada i

            RespuestaDeCliente resp1_llamada2 = new RespuestaDeCliente(respPosPunt2);
            RespuestaDeCliente resp2_llamada2 = new RespuestaDeCliente(respPosProblema2);
            RespuestaDeCliente resp3_llamada2 = new RespuestaDeCliente(respPosVoz4);
            RespuestaDeCliente resp4_llamada2 = new RespuestaDeCliente(respPosTiempo4);
            RespuestaDeCliente resp5_llamada2 = new RespuestaDeCliente(respPosSistema3);
            List<RespuestaDeCliente> respuestas2 = new List<RespuestaDeCliente>() { resp1_llamada2, resp2_llamada2, resp3_llamada2, resp4_llamada2, resp5_llamada2 };

            RespuestaDeCliente resp1_llamada3 = new RespuestaDeCliente(respPosPunt3);
            RespuestaDeCliente resp2_llamada3 = new RespuestaDeCliente(respPosProblema2);
            RespuestaDeCliente resp3_llamada3 = new RespuestaDeCliente(respPosVoz2);
            RespuestaDeCliente resp4_llamada3 = new RespuestaDeCliente(respPosTiempo2);
            RespuestaDeCliente resp5_llamada3 = new RespuestaDeCliente(respPosSistema2);
            List<RespuestaDeCliente> respuestas3 = new List<RespuestaDeCliente>() { resp1_llamada3, resp2_llamada3, resp3_llamada3, resp4_llamada3, resp5_llamada3 };

            RespuestaDeCliente resp1_llamada4 = new RespuestaDeCliente(respPosPunt1);
            RespuestaDeCliente resp2_llamada4 = new RespuestaDeCliente(respPosProblema2);
            RespuestaDeCliente resp3_llamada4 = new RespuestaDeCliente(respPosVoz4);
            RespuestaDeCliente resp4_llamada4 = new RespuestaDeCliente(respPosTiempo1);
            RespuestaDeCliente resp5_llamada4 = new RespuestaDeCliente(respPosSistema3);
            List<RespuestaDeCliente> respuestas4 = new List<RespuestaDeCliente>() { resp1_llamada4, resp2_llamada4, resp3_llamada4, resp4_llamada4, resp5_llamada4 };

            RespuestaDeCliente resp1_llamada5 = new RespuestaDeCliente(respPosPunt5);
            RespuestaDeCliente resp2_llamada5 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada5 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada5 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada5 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas5 = new List<RespuestaDeCliente>() { resp1_llamada5, resp2_llamada5, resp3_llamada5, resp4_llamada5, resp5_llamada5 };

            RespuestaDeCliente resp1_llamada6 = new RespuestaDeCliente(respPosPunt4);
            RespuestaDeCliente resp2_llamada6 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada6 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada6 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada6 = new RespuestaDeCliente(respPosSistema2);
            List<RespuestaDeCliente> respuestas6 = new List<RespuestaDeCliente>() { resp1_llamada6, resp2_llamada6, resp3_llamada6, resp4_llamada6, resp5_llamada6 };

            RespuestaDeCliente resp1_llamada7 = new RespuestaDeCliente(respPosPunt3);
            RespuestaDeCliente resp2_llamada7 = new RespuestaDeCliente(respPosProblema2);
            RespuestaDeCliente resp3_llamada7 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada7 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada7 = new RespuestaDeCliente(respPosSistema2);
            List<RespuestaDeCliente> respuestas7 = new List<RespuestaDeCliente>() { resp1_llamada7, resp2_llamada7, resp3_llamada7, resp4_llamada7, resp5_llamada7 };

            RespuestaDeCliente resp1_llamada8 = new RespuestaDeCliente(respPosPunt5);
            RespuestaDeCliente resp2_llamada8 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada8 = new RespuestaDeCliente(respPosVoz2);
            RespuestaDeCliente resp4_llamada8 = new RespuestaDeCliente(respPosTiempo1);
            RespuestaDeCliente resp5_llamada8 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas8 = new List<RespuestaDeCliente>() { resp1_llamada8, resp2_llamada8, resp3_llamada8, resp4_llamada8, resp5_llamada8 };

            RespuestaDeCliente resp1_llamada9 = new RespuestaDeCliente(respPosPunt5);
            RespuestaDeCliente resp2_llamada9 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada9 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada9 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada9 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas9 = new List<RespuestaDeCliente>() { resp1_llamada9, resp2_llamada9, resp3_llamada9, resp4_llamada9, resp5_llamada9 };

            RespuestaDeCliente resp1_llamada10 = new RespuestaDeCliente(respPosPunt3);
            RespuestaDeCliente resp2_llamada10 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada10 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada10 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada10 = new RespuestaDeCliente(respPosSistema2);
            List<RespuestaDeCliente> respuestas10 = new List<RespuestaDeCliente>() { resp1_llamada10, resp2_llamada10, resp3_llamada10, resp4_llamada10, resp5_llamada10 };

            RespuestaDeCliente resp1_llamada11 = new RespuestaDeCliente(respPosPunt2);
            RespuestaDeCliente resp2_llamada11 = new RespuestaDeCliente(respPosProblema2);
            RespuestaDeCliente resp3_llamada11 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada11 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada11 = new RespuestaDeCliente(respPosSistema3);
            List<RespuestaDeCliente> respuestas11 = new List<RespuestaDeCliente>() { resp1_llamada11, resp2_llamada11, resp3_llamada11, resp4_llamada11, resp5_llamada11 };

            RespuestaDeCliente resp1_llamada12 = new RespuestaDeCliente(respPosPunt4);
            RespuestaDeCliente resp2_llamada12 = new RespuestaDeCliente(respPosProblema2);
            RespuestaDeCliente resp3_llamada12 = new RespuestaDeCliente(respPosVoz1);
            RespuestaDeCliente resp4_llamada12 = new RespuestaDeCliente(respPosTiempo1);
            RespuestaDeCliente resp5_llamada12 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas12 = new List<RespuestaDeCliente>() { resp1_llamada12, resp2_llamada12, resp3_llamada12, resp4_llamada12, resp5_llamada12 };

            RespuestaDeCliente resp1_llamada13 = new RespuestaDeCliente(respPosPunt4);
            RespuestaDeCliente resp2_llamada13 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada13 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada13 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada13 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas13 = new List<RespuestaDeCliente>() { resp1_llamada13, resp2_llamada13, resp3_llamada13, resp4_llamada13, resp5_llamada13 };

            RespuestaDeCliente resp1_llamada14 = new RespuestaDeCliente(respPosPunt5);
            RespuestaDeCliente resp2_llamada14 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada14 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada14 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada14 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas14 = new List<RespuestaDeCliente>() { resp1_llamada14, resp2_llamada14, resp3_llamada14, resp4_llamada14, resp5_llamada14 };

            RespuestaDeCliente resp1_llamada15 = new RespuestaDeCliente(respPosPunt4);
            RespuestaDeCliente resp2_llamada15 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada15 = new RespuestaDeCliente(respPosVoz2);
            RespuestaDeCliente resp4_llamada15 = new RespuestaDeCliente(respPosTiempo2);
            RespuestaDeCliente resp5_llamada15 = new RespuestaDeCliente(respPosSistema2);
            List<RespuestaDeCliente> respuestas15 = new List<RespuestaDeCliente>() { resp1_llamada15, resp2_llamada15, resp3_llamada15, resp4_llamada15, resp5_llamada15 };

            RespuestaDeCliente resp1_llamada16 = new RespuestaDeCliente(respPosPunt5);
            RespuestaDeCliente resp2_llamada16 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada16 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada16 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada16 = new RespuestaDeCliente(respPosSistema1);
            List<RespuestaDeCliente> respuestas16 = new List<RespuestaDeCliente>() { resp1_llamada16, resp2_llamada16, resp3_llamada16, resp4_llamada16, resp5_llamada16 };

            RespuestaDeCliente resp1_llamada17 = new RespuestaDeCliente(respPosPunt4);
            RespuestaDeCliente resp2_llamada17 = new RespuestaDeCliente(respPosProblema1);
            RespuestaDeCliente resp3_llamada17 = new RespuestaDeCliente(respPosVoz5);
            RespuestaDeCliente resp4_llamada17 = new RespuestaDeCliente(respPosTiempo5);
            RespuestaDeCliente resp5_llamada17 = new RespuestaDeCliente(respPosSistema2);
            List<RespuestaDeCliente> respuestas17 = new List<RespuestaDeCliente>() { resp1_llamada17, resp2_llamada17, resp3_llamada17, resp4_llamada17, resp5_llamada17 };

            respuestasDeCliente = new List<RespuestaDeCliente>() 
            {
                resp1_llamada1, resp2_llamada1, resp3_llamada1, resp4_llamada1, resp5_llamada1 ,
                resp1_llamada2, resp2_llamada2, resp3_llamada2, resp4_llamada2, resp5_llamada2 ,
                resp1_llamada3, resp2_llamada3, resp3_llamada3, resp4_llamada3, resp5_llamada3,
                resp1_llamada4, resp2_llamada4, resp3_llamada4, resp4_llamada4, resp5_llamada4,
                resp1_llamada5, resp2_llamada5, resp3_llamada5, resp4_llamada5, resp5_llamada5,
                resp1_llamada6, resp2_llamada6, resp3_llamada6, resp4_llamada6, resp5_llamada6,
                resp1_llamada7, resp2_llamada7, resp3_llamada7, resp4_llamada7, resp5_llamada7,
                resp1_llamada8, resp2_llamada8, resp3_llamada8, resp4_llamada8, resp5_llamada8,
                resp1_llamada9, resp2_llamada9, resp3_llamada9, resp4_llamada9, resp5_llamada9,
                resp1_llamada10, resp2_llamada10, resp3_llamada10, resp4_llamada10, resp5_llamada10,
                resp1_llamada11, resp2_llamada11, resp3_llamada11, resp4_llamada11, resp5_llamada11,
                resp1_llamada12, resp2_llamada12, resp3_llamada12, resp4_llamada12, resp5_llamada12,
                resp1_llamada13, resp2_llamada13, resp3_llamada13, resp4_llamada13, resp5_llamada13,
                resp1_llamada14, resp2_llamada14, resp3_llamada14, resp4_llamada14, resp5_llamada14,
                resp1_llamada15, resp2_llamada15, resp3_llamada15, resp4_llamada15, resp5_llamada15,
                resp1_llamada16, resp2_llamada16, resp3_llamada16, resp4_llamada16, resp5_llamada16,
                resp1_llamada17, resp2_llamada17, resp3_llamada17, resp4_llamada17, resp5_llamada17
            };


            //Encuestas
            Encuesta encuesta1 = new Encuesta("Encuesta general 2023.", preguntas, new DateTime(2023, 12, 31, 23, 59, 59)); //Encuesta vigente

            encuestas = new List<Encuesta>() { encuesta1 };

            //Llamadas
            Llamada llamada1 = new Llamada(cliente1, ce_llamada1, respuestas1, new TimeSpan(0, 1, 21), true);
            Llamada llamada2 = new Llamada(cliente2, ce_llamada2, respuestas2, new TimeSpan(0, 1, 10), true);
            Llamada llamada3 = new Llamada(cliente3, ce_llamada3, respuestas3, new TimeSpan(0, 1, 49), true);
            Llamada llamada4 = new Llamada(cliente4, ce_llamada4, respuestas4, new TimeSpan(0, 0, 39), true);
            Llamada llamada5 = new Llamada(cliente5, ce_llamada5, respuestas5, new TimeSpan(0, 0, 54), true);
            Llamada llamada6 = new Llamada(cliente6, ce_llamada6, respuestas6, new TimeSpan(0, 0, 55), true);
            Llamada llamada7 = new Llamada(cliente7, ce_llamada7, respuestas7, new TimeSpan(0, 2, 13), true);
            Llamada llamada8 = new Llamada(cliente8, ce_llamada8, respuestas8, new TimeSpan(0, 4, 11), true);
            Llamada llamada9 = new Llamada(cliente9, ce_llamada9, respuestas9, new TimeSpan(0, 0, 38), true);
            Llamada llamada10 = new Llamada(cliente10, ce_llamada10, respuestas10, new TimeSpan(0, 0, 52), true);
            Llamada llamada11 = new Llamada(cliente11, ce_llamada11, respuestas11, new TimeSpan(0, 2, 20), true);
            Llamada llamada12 = new Llamada(cliente12, ce_llamada12, respuestas12, new TimeSpan(0, 7, 33), true);
            Llamada llamada13 = new Llamada(cliente13, ce_llamada13, respuestas13, new TimeSpan(0, 0, 45), true);
            Llamada llamada14 = new Llamada(cliente14, ce_llamada14, respuestas14, new TimeSpan(0, 2, 10), true);
            Llamada llamada15 = new Llamada(cliente15, ce_llamada15, respuestas15, new TimeSpan(0, 5, 11), true);
            Llamada llamada16 = new Llamada(cliente16, ce_llamada16, respuestas16, new TimeSpan(0, 8, 28), true);
            Llamada llamada17 = new Llamada(cliente17, ce_llamada17, respuestas17, new TimeSpan(0, 2, 7), true);

            llamadas = new List<Llamada> { llamada1, llamada2, llamada3, llamada4, llamada5, llamada6, llamada7, llamada8, llamada9, llamada10, llamada11, llamada12, llamada13, llamada14, llamada15, llamada16, llamada17 };
        }
        
        public List<Estado> getEstados() { return estados; }
        public List<CambioEstado> getCambioEstados() { return cambioEstados; }
        public List<Cliente> getClientes() { return clientes; }
        public List<Encuesta> getEncuentas() { return encuestas; }
        public List<Llamada> getLlamadas() { return llamadas; }
        public List<Pregunta> getPreguntas() { return preguntas; }
        public List<RespuestaPosible> getRespuestasPosibles() { return respuestasPosibles; }
        public List<RespuestaDeCliente> getRespuestasDeCliente() { return respuestasDeCliente; }
    }
}