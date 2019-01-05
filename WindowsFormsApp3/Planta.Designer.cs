namespace DocumentadorFO
{
    partial class Planta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gvalidaciones = new System.Windows.Forms.GroupBox();
            this.TabPE = new System.Windows.Forms.TabControl();
            this.InformacioEscalamiento = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Plantilla = new System.Windows.Forms.TabPage();
            this.richComentario = new System.Windows.Forms.RichTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSW = new System.Windows.Forms.TextBox();
            this.txtOTinstalacion = new System.Windows.Forms.TextBox();
            this.txtContactoDelCliente = new System.Windows.Forms.TextBox();
            this.txtFechayhoraventana = new System.Windows.Forms.TextBox();
            this.lbltopologia = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbSegmento = new System.Windows.Forms.ComboBox();
            this.txtSubsegmento = new System.Windows.Forms.TextBox();
            this.lblSWACCESO = new System.Windows.Forms.Label();
            this.lblPUERTOFISICO = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richObservaciones = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblEnlace = new System.Windows.Forms.Label();
            this.lblEquipos = new System.Windows.Forms.Label();
            this.lblpuertoo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSereportacon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Gvalidaciones.SuspendLayout();
            this.TabPE.SuspendLayout();
            this.InformacioEscalamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Plantilla.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "SIN SERVICIO";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(142, 630);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(225, 58);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "VDN: 416819           \n                      \n                       \n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(104, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "DISPONIBILIDAD 7 X 24";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Gvalidaciones
            // 
            this.Gvalidaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Gvalidaciones.Controls.Add(this.TabPE);
            this.Gvalidaciones.Location = new System.Drawing.Point(371, 41);
            this.Gvalidaciones.Name = "Gvalidaciones";
            this.Gvalidaciones.Size = new System.Drawing.Size(422, 568);
            this.Gvalidaciones.TabIndex = 36;
            this.Gvalidaciones.TabStop = false;
            this.Gvalidaciones.Text = "VALIDACIONES";
            this.Gvalidaciones.Enter += new System.EventHandler(this.Gvalidaciones_Enter);
            // 
            // TabPE
            // 
            this.TabPE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPE.Controls.Add(this.InformacioEscalamiento);
            this.TabPE.Controls.Add(this.Plantilla);
            this.TabPE.Location = new System.Drawing.Point(6, 23);
            this.TabPE.Name = "TabPE";
            this.TabPE.SelectedIndex = 0;
            this.TabPE.Size = new System.Drawing.Size(410, 545);
            this.TabPE.TabIndex = 14;
            // 
            // InformacioEscalamiento
            // 
            this.InformacioEscalamiento.Controls.Add(this.pictureBox2);
            this.InformacioEscalamiento.Location = new System.Drawing.Point(4, 22);
            this.InformacioEscalamiento.Name = "InformacioEscalamiento";
            this.InformacioEscalamiento.Size = new System.Drawing.Size(402, 519);
            this.InformacioEscalamiento.TabIndex = 0;
            this.InformacioEscalamiento.Text = "Informacion Escalamiento";
            this.InformacioEscalamiento.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::DocumentadorFO12.Properties.Resources.Seguimiento_plantilla_PE_como_documentarla;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 519);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Plantilla
            // 
            this.Plantilla.Controls.Add(this.richComentario);
            this.Plantilla.Location = new System.Drawing.Point(4, 22);
            this.Plantilla.Name = "Plantilla";
            this.Plantilla.Size = new System.Drawing.Size(402, 519);
            this.Plantilla.TabIndex = 1;
            this.Plantilla.Text = "Plantilla";
            this.Plantilla.UseVisualStyleBackColor = true;
            // 
            // richComentario
            // 
            this.richComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richComentario.Location = new System.Drawing.Point(0, 0);
            this.richComentario.Name = "richComentario";
            this.richComentario.Size = new System.Drawing.Size(402, 519);
            this.richComentario.TabIndex = 0;
            this.richComentario.Text = "";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(103, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtSW
            // 
            this.txtSW.Location = new System.Drawing.Point(103, 147);
            this.txtSW.Name = "txtSW";
            this.txtSW.Size = new System.Drawing.Size(229, 20);
            this.txtSW.TabIndex = 6;
            // 
            // txtOTinstalacion
            // 
            this.txtOTinstalacion.Location = new System.Drawing.Point(103, 194);
            this.txtOTinstalacion.Name = "txtOTinstalacion";
            this.txtOTinstalacion.Size = new System.Drawing.Size(229, 20);
            this.txtOTinstalacion.TabIndex = 8;
            // 
            // txtContactoDelCliente
            // 
            this.txtContactoDelCliente.Location = new System.Drawing.Point(114, 218);
            this.txtContactoDelCliente.Name = "txtContactoDelCliente";
            this.txtContactoDelCliente.Size = new System.Drawing.Size(218, 20);
            this.txtContactoDelCliente.TabIndex = 9;
            // 
            // txtFechayhoraventana
            // 
            this.txtFechayhoraventana.Location = new System.Drawing.Point(150, 241);
            this.txtFechayhoraventana.Name = "txtFechayhoraventana";
            this.txtFechayhoraventana.Size = new System.Drawing.Size(182, 20);
            this.txtFechayhoraventana.TabIndex = 10;
            // 
            // lbltopologia
            // 
            this.lbltopologia.AutoSize = true;
            this.lbltopologia.Location = new System.Drawing.Point(7, 147);
            this.lbltopologia.Name = "lbltopologia";
            this.lbltopologia.Size = new System.Drawing.Size(39, 13);
            this.lbltopologia.TabIndex = 33;
            this.lbltopologia.Text = "Switch";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(103, 170);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(229, 20);
            this.txtPuerto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Se reporta con:";
            // 
            // CmbSegmento
            // 
            this.CmbSegmento.FormattingEnabled = true;
            this.CmbSegmento.Items.AddRange(new object[] {
            "PYME",
            "CORPORATIVO"});
            this.CmbSegmento.Location = new System.Drawing.Point(103, 29);
            this.CmbSegmento.Name = "CmbSegmento";
            this.CmbSegmento.Size = new System.Drawing.Size(229, 21);
            this.CmbSegmento.TabIndex = 1;
            // 
            // txtSubsegmento
            // 
            this.txtSubsegmento.Location = new System.Drawing.Point(103, 53);
            this.txtSubsegmento.Name = "txtSubsegmento";
            this.txtSubsegmento.Size = new System.Drawing.Size(229, 20);
            this.txtSubsegmento.TabIndex = 2;
            // 
            // lblSWACCESO
            // 
            this.lblSWACCESO.AutoSize = true;
            this.lblSWACCESO.Location = new System.Drawing.Point(7, 32);
            this.lblSWACCESO.Name = "lblSWACCESO";
            this.lblSWACCESO.Size = new System.Drawing.Size(55, 13);
            this.lblSWACCESO.TabIndex = 28;
            this.lblSWACCESO.Text = "Segmento";
            // 
            // lblPUERTOFISICO
            // 
            this.lblPUERTOFISICO.AutoSize = true;
            this.lblPUERTOFISICO.Location = new System.Drawing.Point(7, 55);
            this.lblPUERTOFISICO.Name = "lblPUERTOFISICO";
            this.lblPUERTOFISICO.Size = new System.Drawing.Size(72, 13);
            this.lblPUERTOFISICO.TabIndex = 27;
            this.lblPUERTOFISICO.Text = "Subsegmento";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(103, 123);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(229, 20);
            this.txtCiudad.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richObservaciones);
            this.groupBox4.Location = new System.Drawing.Point(10, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 141);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descripcion de la actividad";
            // 
            // richObservaciones
            // 
            this.richObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richObservaciones.Location = new System.Drawing.Point(3, 16);
            this.richObservaciones.Name = "richObservaciones";
            this.richObservaciones.Size = new System.Drawing.Size(316, 122);
            this.richObservaciones.TabIndex = 12;
            this.richObservaciones.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "VDN DEFINIDO PARA \r\nTODAS LAS AREAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(7, 100);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(55, 13);
            this.lblDir.TabIndex = 14;
            this.lblDir.Text = "Dirección:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(8, 123);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(40, 13);
            this.lblHorario.TabIndex = 13;
            this.lblHorario.Text = "Ciudad";
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(7, 194);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(76, 13);
            this.lblPermisos.TabIndex = 11;
            this.lblPermisos.Text = "OT Instalacion";
            // 
            // lblEnlace
            // 
            this.lblEnlace.AutoSize = true;
            this.lblEnlace.Location = new System.Drawing.Point(7, 221);
            this.lblEnlace.Name = "lblEnlace";
            this.lblEnlace.Size = new System.Drawing.Size(101, 13);
            this.lblEnlace.TabIndex = 10;
            this.lblEnlace.Text = "Contacto del cliente";
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.Location = new System.Drawing.Point(7, 244);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(137, 13);
            this.lblEquipos.TabIndex = 9;
            this.lblEquipos.Text = "Fecha y hora de la ventana";
            // 
            // lblpuertoo
            // 
            this.lblpuertoo.AutoSize = true;
            this.lblpuertoo.Location = new System.Drawing.Point(6, 170);
            this.lblpuertoo.Name = "lblpuertoo";
            this.lblpuertoo.Size = new System.Drawing.Size(41, 13);
            this.lblpuertoo.TabIndex = 2;
            this.lblpuertoo.Text = "Puerto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltopologia);
            this.groupBox1.Controls.Add(this.txtPuerto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbSegmento);
            this.groupBox1.Controls.Add(this.txtSubsegmento);
            this.groupBox1.Controls.Add(this.lblSWACCESO);
            this.groupBox1.Controls.Add(this.lblPUERTOFISICO);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtSW);
            this.groupBox1.Controls.Add(this.txtOTinstalacion);
            this.groupBox1.Controls.Add(this.txtContactoDelCliente);
            this.groupBox1.Controls.Add(this.txtFechayhoraventana);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.lblPermisos);
            this.groupBox1.Controls.Add(this.lblEnlace);
            this.groupBox1.Controls.Add(this.lblEquipos);
            this.groupBox1.Controls.Add(this.lblpuertoo);
            this.groupBox1.Controls.Add(this.txtSereportacon);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 421);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION  ESCALAMIENTO PLANTA EXTERNA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSereportacon
            // 
            this.txtSereportacon.Location = new System.Drawing.Point(103, 77);
            this.txtSereportacon.Name = "txtSereportacon";
            this.txtSereportacon.Size = new System.Drawing.Size(229, 20);
            this.txtSereportacon.TabIndex = 3;
            this.txtSereportacon.Text = "Nombre del Ing del NOC que atiende";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(663, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DocumentadorFO12.Properties.Resources.Planta_externa;
            this.pictureBox3.Location = new System.Drawing.Point(75, 439);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(224, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // Planta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 726);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gvalidaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Planta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planta";
            this.Load += new System.EventHandler(this.Planta_Load);
            this.Gvalidaciones.ResumeLayout(false);
            this.TabPE.ResumeLayout(false);
            this.InformacioEscalamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Plantilla.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gvalidaciones;
        public System.Windows.Forms.TabControl TabPE;
        private System.Windows.Forms.TabPage InformacioEscalamiento;
        private System.Windows.Forms.TabPage Plantilla;
        private System.Windows.Forms.RichTextBox richComentario;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtSW;
        public System.Windows.Forms.TextBox txtOTinstalacion;
        public System.Windows.Forms.TextBox txtContactoDelCliente;
        public System.Windows.Forms.TextBox txtFechayhoraventana;
        private System.Windows.Forms.Label lbltopologia;
        public System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CmbSegmento;
        public System.Windows.Forms.TextBox txtSubsegmento;
        private System.Windows.Forms.Label lblSWACCESO;
        private System.Windows.Forms.Label lblPUERTOFISICO;
        public System.Windows.Forms.TextBox txtCiudad;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.RichTextBox richObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblEnlace;
        private System.Windows.Forms.Label lblEquipos;
        private System.Windows.Forms.Label lblpuertoo;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtSereportacon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}