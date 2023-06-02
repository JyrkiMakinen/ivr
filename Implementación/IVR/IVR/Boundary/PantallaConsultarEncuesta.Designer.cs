namespace IVR.Boundary
{
    partial class PantallaConsultarEncuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.lblClienteInfo = new System.Windows.Forms.Label();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.cmbLlamada = new System.Windows.Forms.ComboBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlCsv = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbFormaVisualizacion = new System.Windows.Forms.ComboBox();
            this.lblVisualizacion = new System.Windows.Forms.Label();
            this.lblEncuesta = new System.Windows.Forms.Label();
            this.lblEncuestaInfo = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDuracionInfo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoInfo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.grdEncuesta = new System.Windows.Forms.DataGridView();
            this.preguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlCsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(55)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1184, 100);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(395, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consultar Encuesta";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(35, 34);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(167, 24);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Inicio del período:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtpInicio.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(208, 33);
            this.dtpInicio.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(133, 27);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.Value = new System.DateTime(2023, 5, 28, 11, 8, 53, 0);
            this.dtpInicio.ValueChanged += new System.EventHandler(this.tomarFechaInicio);
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dtpFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtpFin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(548, 33);
            this.dtpFin.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(133, 27);
            this.dtpFin.TabIndex = 4;
            this.dtpFin.Value = new System.DateTime(2023, 6, 28, 11, 8, 0, 0);
            this.dtpFin.ValueChanged += new System.EventHandler(this.tomarFechaFin);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(395, 34);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(147, 24);
            this.lblFechaFin.TabIndex = 3;
            this.lblFechaFin.Text = "Fin del período:";
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.Location = new System.Drawing.Point(34, 91);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(261, 29);
            this.lblLlamada.TabIndex = 5;
            this.lblLlamada.Text = "Seleccione una llamada:";
            // 
            // lblClienteInfo
            // 
            this.lblClienteInfo.AutoSize = true;
            this.lblClienteInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteInfo.Location = new System.Drawing.Point(29, 98);
            this.lblClienteInfo.Name = "lblClienteInfo";
            this.lblClienteInfo.Size = new System.Drawing.Size(79, 24);
            this.lblClienteInfo.TabIndex = 7;
            this.lblClienteInfo.Text = "Cliente: ";
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.cmbLlamada);
            this.pnlPeriodo.Controls.Add(this.lblFechaInicio);
            this.pnlPeriodo.Controls.Add(this.dtpInicio);
            this.pnlPeriodo.Controls.Add(this.lblFechaFin);
            this.pnlPeriodo.Controls.Add(this.lblLlamada);
            this.pnlPeriodo.Controls.Add(this.dtpFin);
            this.pnlPeriodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPeriodo.Location = new System.Drawing.Point(0, 100);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(786, 153);
            this.pnlPeriodo.TabIndex = 8;
            // 
            // cmbLlamada
            // 
            this.cmbLlamada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLlamada.FormattingEnabled = true;
            this.cmbLlamada.Location = new System.Drawing.Point(301, 90);
            this.cmbLlamada.Name = "cmbLlamada";
            this.cmbLlamada.Size = new System.Drawing.Size(380, 32);
            this.cmbLlamada.TabIndex = 6;
            this.cmbLlamada.DropDown += new System.EventHandler(this.informarSinLlamadas);
            this.cmbLlamada.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionLlamada);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnlInfo.Controls.Add(this.pnlCsv);
            this.pnlInfo.Controls.Add(this.lblEncuesta);
            this.pnlInfo.Controls.Add(this.lblEncuestaInfo);
            this.pnlInfo.Controls.Add(this.lblDuracion);
            this.pnlInfo.Controls.Add(this.lblDuracionInfo);
            this.pnlInfo.Controls.Add(this.lblEstado);
            this.pnlInfo.Controls.Add(this.lblEstadoInfo);
            this.pnlInfo.Controls.Add(this.lblCliente);
            this.pnlInfo.Controls.Add(this.lblInformacion);
            this.pnlInfo.Controls.Add(this.lblClienteInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(786, 100);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(398, 461);
            this.pnlInfo.TabIndex = 9;
            // 
            // pnlCsv
            // 
            this.pnlCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlCsv.Controls.Add(this.btnCancelar);
            this.pnlCsv.Controls.Add(this.btnGenerar);
            this.pnlCsv.Controls.Add(this.cmbFormaVisualizacion);
            this.pnlCsv.Controls.Add(this.lblVisualizacion);
            this.pnlCsv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCsv.Location = new System.Drawing.Point(0, 351);
            this.pnlCsv.Name = "pnlCsv";
            this.pnlCsv.Size = new System.Drawing.Size(398, 110);
            this.pnlCsv.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancelar.Location = new System.Drawing.Point(24, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 39);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.tomarCancelacion);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(55)))));
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(110)))), ((int)(((byte)(45)))));
            this.btnGenerar.FlatAppearance.BorderSize = 3;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnGenerar.Location = new System.Drawing.Point(166, 59);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(217, 39);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "Generar archivo";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.tomarSeleccionFormaVisualización);
            // 
            // cmbFormaVisualizacion
            // 
            this.cmbFormaVisualizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaVisualizacion.Enabled = false;
            this.cmbFormaVisualizacion.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaVisualizacion.FormattingEnabled = true;
            this.cmbFormaVisualizacion.Items.AddRange(new object[] {
            "CSV",
            "Impresión"});
            this.cmbFormaVisualizacion.Location = new System.Drawing.Point(246, 15);
            this.cmbFormaVisualizacion.Name = "cmbFormaVisualizacion";
            this.cmbFormaVisualizacion.Size = new System.Drawing.Size(121, 30);
            this.cmbFormaVisualizacion.TabIndex = 18;
            // 
            // lblVisualizacion
            // 
            this.lblVisualizacion.AutoSize = true;
            this.lblVisualizacion.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblVisualizacion.Location = new System.Drawing.Point(20, 18);
            this.lblVisualizacion.Name = "lblVisualizacion";
            this.lblVisualizacion.Size = new System.Drawing.Size(220, 24);
            this.lblVisualizacion.TabIndex = 17;
            this.lblVisualizacion.Text = "Forma de Visualización: ";
            // 
            // lblEncuesta
            // 
            this.lblEncuesta.AutoSize = true;
            this.lblEncuesta.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuesta.Location = new System.Drawing.Point(134, 234);
            this.lblEncuesta.Name = "lblEncuesta";
            this.lblEncuesta.Size = new System.Drawing.Size(0, 24);
            this.lblEncuesta.TabIndex = 15;
            // 
            // lblEncuestaInfo
            // 
            this.lblEncuestaInfo.AutoSize = true;
            this.lblEncuestaInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuestaInfo.Location = new System.Drawing.Point(29, 234);
            this.lblEncuestaInfo.Name = "lblEncuestaInfo";
            this.lblEncuestaInfo.Size = new System.Drawing.Size(96, 24);
            this.lblEncuestaInfo.TabIndex = 14;
            this.lblEncuestaInfo.Text = "Encuesta: ";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(134, 189);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(0, 24);
            this.lblDuracion.TabIndex = 13;
            // 
            // lblDuracionInfo
            // 
            this.lblDuracionInfo.AutoSize = true;
            this.lblDuracionInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionInfo.Location = new System.Drawing.Point(29, 189);
            this.lblDuracionInfo.Name = "lblDuracionInfo";
            this.lblDuracionInfo.Size = new System.Drawing.Size(99, 24);
            this.lblDuracionInfo.TabIndex = 12;
            this.lblDuracionInfo.Text = "Duración: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(114, 143);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 24);
            this.lblEstado.TabIndex = 11;
            // 
            // lblEstadoInfo
            // 
            this.lblEstadoInfo.AutoSize = true;
            this.lblEstadoInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoInfo.Location = new System.Drawing.Point(29, 143);
            this.lblEstadoInfo.Name = "lblEstadoInfo";
            this.lblEstadoInfo.Size = new System.Drawing.Size(79, 24);
            this.lblEstadoInfo.TabIndex = 10;
            this.lblEstadoInfo.Text = "Estado: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(114, 98);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 24);
            this.lblCliente.TabIndex = 9;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(53, 31);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(314, 31);
            this.lblInformacion.TabIndex = 8;
            this.lblInformacion.Text = "Información de la llamada";
            // 
            // grdEncuesta
            // 
            this.grdEncuesta.AllowUserToAddRows = false;
            this.grdEncuesta.AllowUserToDeleteRows = false;
            this.grdEncuesta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdEncuesta.CausesValidation = false;
            this.grdEncuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEncuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preguntas,
            this.respuestas});
            this.grdEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEncuesta.GridColor = System.Drawing.SystemColors.Control;
            this.grdEncuesta.Location = new System.Drawing.Point(0, 253);
            this.grdEncuesta.Name = "grdEncuesta";
            this.grdEncuesta.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grdEncuesta.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEncuesta.Size = new System.Drawing.Size(786, 308);
            this.grdEncuesta.TabIndex = 10;
            // 
            // preguntas
            // 
            this.preguntas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preguntas.DataPropertyName = "preguntas";
            this.preguntas.FillWeight = 60F;
            this.preguntas.HeaderText = "Preguntas";
            this.preguntas.Name = "preguntas";
            this.preguntas.ReadOnly = true;
            // 
            // respuestas
            // 
            this.respuestas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.respuestas.DataPropertyName = "respuestas";
            this.respuestas.FillWeight = 40F;
            this.respuestas.HeaderText = "Respuestas";
            this.respuestas.Name = "respuestas";
            this.respuestas.ReadOnly = true;
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.grdEncuesta);
            this.Controls.Add(this.pnlPeriodo);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Name = "PantallaConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlCsv.ResumeLayout(false);
            this.pnlCsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncuesta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Label lblClienteInfo;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblEncuesta;
        private System.Windows.Forms.Label lblEncuestaInfo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblDuracionInfo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoInfo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridView grdEncuesta;
        private System.Windows.Forms.Panel pnlCsv;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbFormaVisualizacion;
        private System.Windows.Forms.Label lblVisualizacion;
        private System.Windows.Forms.ComboBox cmbLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestas;
        private System.Windows.Forms.Button btnCancelar;
    }
}