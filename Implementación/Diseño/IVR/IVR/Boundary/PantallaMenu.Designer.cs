namespace IVR.Boundary
{
    partial class PantallaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMenu));
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnConsultarEncuesta = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picMenu
            // 
            this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(79, 41);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(400, 349);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            // 
            // btnConsultarEncuesta
            // 
            this.btnConsultarEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(115)))));
            this.btnConsultarEncuesta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(75)))));
            this.btnConsultarEncuesta.FlatAppearance.BorderSize = 3;
            this.btnConsultarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEncuesta.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEncuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnConsultarEncuesta.Location = new System.Drawing.Point(157, 412);
            this.btnConsultarEncuesta.Name = "btnConsultarEncuesta";
            this.btnConsultarEncuesta.Size = new System.Drawing.Size(247, 61);
            this.btnConsultarEncuesta.TabIndex = 20;
            this.btnConsultarEncuesta.Text = "Consultar encuesta";
            this.btnConsultarEncuesta.UseVisualStyleBackColor = false;
            this.btnConsultarEncuesta.Click += new System.EventHandler(this.btnConsultarEncuesta_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(121, 515);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(331, 23);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 21;
            this.prgBar.Visible = false;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F);
            this.lblCargando.Location = new System.Drawing.Point(200, 490);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(155, 20);
            this.lblCargando.TabIndex = 22;
            this.lblCargando.Text = "Obteniendo datos...";
            this.lblCargando.Visible = false;
            // 
            // PantallaMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(558, 548);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.btnConsultarEncuesta);
            this.Controls.Add(this.picMenu);
            this.Name = "PantallaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ivr.app";
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnConsultarEncuesta;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label lblCargando;
    }
}