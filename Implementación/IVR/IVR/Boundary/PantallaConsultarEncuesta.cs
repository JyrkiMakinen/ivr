using IVR.Control;
﻿using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IVR.Boundary
{
    public partial class PantallaConsultarEncuesta : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private GestorConsultarEncuesta gestorConsultarEncuesta;
        private List<Llamada> llamadasEncontradas;

        public DateTime getFechaInicio () {
            return fechaInicio;
        }

        public DateTime getFechaFin()
        {
            return fechaFin;
        }

        public PantallaConsultarEncuesta()
        {
            opcionConsultarEncuesta();
        }

        public void opcionConsultarEncuesta()
        {
            habilitarPantalla();
        }

        public void habilitarPantalla()
        {
            InitializeComponent();
            gestorConsultarEncuesta.opcionConsultarEncuesta();
        }

        public void solicitarPeriodo()
        {
            //Esperar a que seleccione fechas
        }

        public void tomarFechaInicio(object sender, EventArgs e)
        {
            //Esperar a que seleccione fecha fin
        }

        public void tomarFechaFin()
        {
            gestor.tomarPeriodo(dtpInicio.Value, dtpFin.Value);
        }
        public void solicitarPeriodo() {
            // Mostrar formulario de filtro de fechas e indicar que ingrese una fecha desde y hasta.
        }

        // Definir si es necesario para la entrega este nuevo metodo
        public bool validarFormatoFecha(string txtFecha) {
            if(txtFecha.Text == "") {
                MessageBox.Show("Campo de fecha requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFecha.Focus();
                return false;
            }
            if (!DateTime.TryParseExact(txtFecha.Text, "d/M/yyyy", null, DateTimeStyles.None, out _) &&
                !DateTime.TryParseExact(txtFecha.Text, "d-M-yyyy", null, DateTimeStyles.None, out _)) {
                MessageBox.Show("Formato de fecha inválido. El formato debe ser dd/mm/aaaa o dd-mm-aaaa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFecha.Focus();
                return false;
            }
            return true;
        }

        public void tomarFechaInicio() {
            this.fechaInicio = DateTime.ParseExact(this.txtFechaInicio.Text, "d/M/yyyy", null);
        }

        public void tomarFechaFin() {
            this.fechaFin = DateTime.ParseExact(this.txtFechaFin.Text, "d/M/yyyy", null);
        }

        public void btnFiltrarLlamadas_Click(object sender, EventArgs e) { // Metodo para cuando se haga click en el boton Filtrar
            tomarFechaInicio();
            tomarFechaFin();

            if (validarFormatoFecha(this.txtFechaInicio) && validarFormatoFecha(this.txtFechaFin)) {
                gestorConsultarEncuesta.tomarPeriodo(this.fechaInicio, this.fechaFin);
            }
        }

        public void solicitarSeleccionLlamada(List<Llamada> llamadasConEncuestasRespondidasDelPeriodo) {
            this.llamadasEncontradas = llamadasConEncuestasRespondidasDelPeriodo;

            if (llamadasEncontradas.Count() > 0) {
                for (int i = 0; i < llamadasEncontradas.Count(); i++) {
                    Llamada llamadaEncontrada = llamadasEncontradas[i];
                    // nueva fila en la tabla
                    int index = dtgvLlamadasEncontradas.Rows.Add();

                    // rellenamos la data de cada celda de la fila
                    dtgvLlamadasEncontradas.Rows[index].Cells[0].Value = llamadaEncontrada.encuestaEnviada;
                    dtgvLlamadasEncontradas.Rows[index].Cells[1].Value = "" // fecha de la llamada? duracion? A definir los datos de la llamada que mostramos en la tabla
                }
            } else {
                //
                // Flujo Alternativo A1: No hay llamadas en el período con encuestas respondidas.
                //
            }
        }

        public void tomarSeleccionLlamada(object sender, EventArgs e) { // Metodo para cuando se haga doble click en una fila / celda
            int indexSelected = e.RowIndex;
            if (indexSelected != -1) {
                Llamada llamadaSeleccionada = llamadasEncontradas[indexSelected];
                gestorConsultarEncuesta.tomarSeleccionLlamada(llamadaSeleccionada);
            }
        }

        public void mostrarEncuesta(/* mil cosas */)
        {
            // Recibo todos los datos que me van a mandar los wachines del gestor
        }

        public void soliciarSeleccionFormaVisualización()
        {

        }

        public void tomarSeleccionFormaVisualización()
        {

        }


    }
}
