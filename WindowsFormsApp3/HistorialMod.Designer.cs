namespace DocumentadorFO12
{
    partial class HistorialMod
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
            this.richHistMod = new System.Windows.Forms.RichTextBox();
            this.btnmod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richHistMod
            // 
            this.richHistMod.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.richHistMod.Location = new System.Drawing.Point(0, 0);
            this.richHistMod.Name = "richHistMod";
            this.richHistMod.ReadOnly = true;
            this.richHistMod.Size = new System.Drawing.Size(671, 512);
            this.richHistMod.TabIndex = 0;
            this.richHistMod.Text = "";
            // 
            // btnmod
            // 
            this.btnmod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.btnmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.ForeColor = System.Drawing.Color.White;
            this.btnmod.Location = new System.Drawing.Point(537, 518);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(122, 36);
            this.btnmod.TabIndex = 108;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // HistorialMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 565);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.richHistMod);
            this.Name = "HistorialMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial De Modificaciones";
            this.Load += new System.EventHandler(this.HistorialMod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richHistMod;
        private System.Windows.Forms.Button btnmod;
    }
}