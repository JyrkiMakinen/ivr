using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVR.Boundary;
using IVR.Datos;
using IVR.Entity;

namespace IVR.Control
{   

    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo; 
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private GeneradorDeDatos generadorDeDatos;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantalla) {
            this.generadorDeDatos = new GeneradorDeDatos();
            this.pantallaConsultarEncuesta = pantalla;
        }

        public void opcionConsultarEncuesta() {

        }
        
        public void tomarPeriodo()
        {
            this.fechaInicioPeriodo = pantallaConsultarEncuesta.getFechaInicio();
            this.fechaFinPeriodo = pantallaConsultarEncuesta.getFechaFin();
        }


        public void buscarLlamadasConEncRespondidas() {
            List<Llamada> listLlamadas = generadorDeDatos.getLlamadas();
            List<Llamada> llamdasConEncuestasRespondidas = new List<Llamada>();
            for (int i = 0; i < listLlamadas.Count(); i++) {
                if (listLlamadas[i].tieneEncuestasRespondidas()) {
                    llamdasConEncuestasRespondidas.Add(listLlamadas[i]);



                }
            }


        }

        public void tomarSeleccionLlamada() {

        }


        public void obtenerDatos() {

        }

        public void tomarSeleccionFormaVisualizacion() {

        }

        public void generarCsv() {

        }

        public void finCU() {

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
