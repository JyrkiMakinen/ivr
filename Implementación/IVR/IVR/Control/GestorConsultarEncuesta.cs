using IVR.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IVR.Control
{

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private string nombreCliente;
        private TimeSpan duracion;
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantalla)
        {
            this.generadorDeDatos = new GeneradorDeDatos();
            this.pantallaConsultarEncuesta = pantalla;
        }

        public void opcionConsultarEncuesta()
        {
            pantallaConsultarEncuesta.solicitarPeriodo();
        }
<<<<<<< HEAD

        public void tomarPeriodo()
=======
        
        public void tomarPeriodo(DateTime fechaInicio, DateTime fechaFin)
>>>>>>> 6a26e101d4bb4fa689063310c1e2b0643f5e0d1c
        {
            this.fechaInicioPeriodo = fechaInicio;
            this.fechaFinPeriodo = fechaFin;
            buscarLlamadasConEncRespondidas();
        }


<<<<<<< HEAD
        public void buscarLlamadasConEncRespondidas()
        {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamadasConEncuestasRespondidasDelPeriodo = new List<Llamada>();
            List<DateTime> fechasYHorasDeLlamadasConEncResp = new List<DateTime>();
            foreach (Llamada llamada in listLlamadas)
            {
                if (llamada.tieneEncuestasRespondidas())
                {
                    if (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo))
                    {
                        llamadasConEncuestasRespondidasDelPeriodo.Add(llamada);
                        fechasYHorasDeLlamadasConEncResp.Add(llamada.getFechaHoraInicio()); //Cambiar en el diag de secuencia, se llama desde el gestor
=======
        public void buscarLlamadasConEncRespondidas() {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamadasConEncuestasRespondidasDelPeriodo = new List<Llamada>();
            for (int i = 0; i < listLlamadas.Count(); i++) {
                if (listLlamadas[i].tieneEncuestasRespondidas()) {
                    if (listLlamadas[i].esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo)) {
                        llamadasConEncuestasRespondidasDelPeriodo.Add(listLlamadas[i]);
>>>>>>> 6a26e101d4bb4fa689063310c1e2b0643f5e0d1c
                    }
                }
            }

<<<<<<< HEAD
            pantallaConsultarEncuesta.solicitarSeleccionLlamada(llamadasConEncuestasRespondidasDelPeriodo, fechasYHorasDeLlamadasConEncResp);
=======
            pantallaConsultarEncuesta.solicitarSeleccionLlamada(llamadasConEncuestasRespondidasDelPeriodo);
>>>>>>> 6a26e101d4bb4fa689063310c1e2b0643f5e0d1c
        }

        public void tomarSeleccionLlamada(Llamada llamadaSeleccionada)
        {
            obtenerDatos(llamadaSeleccionada);
        }


        public void obtenerDatos(Llamada llamadaSeleccionada)
        {
            this.nombreCliente = llamadaSeleccionada.getNombreClienteDeLlamada();
            string estadoActual = llamadaSeleccionada.getEstadoActual();
            this.duracion = llamadaSeleccionada.calcularDuracion();


            llamadaSeleccionada.getRespuestas();

            pantallaConsultarEncuesta.mostrarEncuesta();
            pantallaConsultarEncuesta.solicitarSeleccionFormaVisualizacon();
        }

        public void tomarSeleccionFormaVisualizacion(string formaVisualizacion)
        {
            if (formaVisualizacion.Equals("csv"))
            {
                generarCsv();
            }
        }

        public void generarCsv()
        {
            //generar el csv


            finCU();
        }

        public void finCU()
        {
            
        }


        public void setFechaInicioPeriodo(DateTime dateTime)
        {
            this.fechaInicioPeriodo = dateTime;
        }

        public void setFechaFinPeriodo(DateTime dateTime)
        {
            this.fechaFinPeriodo = dateTime;
        }

        public DateTime setFechaInicioPeriodo()
        {
            return this.fechaInicioPeriodo;
        }

        public DateTime setFechaFinPeriodo()
        {
            return this.fechaFinPeriodo;
        }

    }
}
