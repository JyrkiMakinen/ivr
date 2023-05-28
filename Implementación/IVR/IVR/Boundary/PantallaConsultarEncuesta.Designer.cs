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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.cmbLlamada = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdEncuesta = new System.Windows.Forms.DataGridView();
            this.preguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblValorCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEncuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(120)))), ((int)(((byte)(55)))));
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
            // cmbLlamada
            // 
            this.cmbLlamada.FormattingEnabled = true;
            this.cmbLlamada.Location = new System.Drawing.Point(301, 90);
            this.cmbLlamada.Name = "cmbLlamada";
            this.cmbLlamada.Size = new System.Drawing.Size(258, 32);
            this.cmbLlamada.TabIndex = 6;
            this.cmbLlamada.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionLlamada);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(29, 98);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 24);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFechaInicio);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.cmbLlamada);
            this.panel1.Controls.Add(this.lblFechaFin);
            this.panel1.Controls.Add(this.lblLlamada);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 153);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblValorCliente);
            this.panel2.Controls.Add(this.lblInformacion);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(786, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 461);
            this.panel2.TabIndex = 9;
            // 
            // grdEncuesta
            // 
            this.grdEncuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEncuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preguntas,
            this.respuestas});
            this.grdEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEncuesta.Location = new System.Drawing.Point(0, 253);
            this.grdEncuesta.Name = "grdEncuesta";
            this.grdEncuesta.Size = new System.Drawing.Size(786, 308);
            this.grdEncuesta.TabIndex = 10;
            // 
            // preguntas
            // 
            this.preguntas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preguntas.HeaderText = "Preguntas";
            this.preguntas.Name = "preguntas";
            // 
            // respuestas
            // 
            this.respuestas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.respuestas.FillWeight = 30F;
            this.respuestas.HeaderText = "Respuestas";
            this.respuestas.Name = "respuestas";
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
            // lblValorCliente
            // 
            this.lblValorCliente.AutoSize = true;
            this.lblValorCliente.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCliente.Location = new System.Drawing.Point(114, 98);
            this.lblValorCliente.Name = "lblValorCliente";
            this.lblValorCliente.Size = new System.Drawing.Size(183, 24);
            this.lblValorCliente.TabIndex = 9;
            this.lblValorCliente.Text = "[nombre del cliente]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "[nombre del estado]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duración: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "[duracion]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Encuesta: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "[descripcion de la encuesta]";
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.grdEncuesta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Name = "PantallaConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbLlamada;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorCliente;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridView grdEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestas;
    }
}