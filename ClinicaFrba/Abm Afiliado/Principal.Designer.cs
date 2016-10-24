namespace ClinicaFrba.Abm_Afiliado
{
    partial class Principal
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
            this.botonDeAlta = new System.Windows.Forms.Button();
            this.botonDeBaja = new System.Windows.Forms.Button();
            this.botonDeModificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDeAlta
            // 
            this.botonDeAlta.Location = new System.Drawing.Point(12, 66);
            this.botonDeAlta.Name = "botonDeAlta";
            this.botonDeAlta.Size = new System.Drawing.Size(260, 30);
            this.botonDeAlta.TabIndex = 2;
            this.botonDeAlta.Text = "Alta";
            this.botonDeAlta.UseVisualStyleBackColor = true;
            this.botonDeAlta.Click += new System.EventHandler(this.button3_Click);
            // 
            // botonDeBaja
            // 
            this.botonDeBaja.Location = new System.Drawing.Point(12, 115);
            this.botonDeBaja.Name = "botonDeBaja";
            this.botonDeBaja.Size = new System.Drawing.Size(260, 30);
            this.botonDeBaja.TabIndex = 3;
            this.botonDeBaja.Text = "Baja";
            this.botonDeBaja.UseVisualStyleBackColor = true;
            this.botonDeBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonDeModificacion
            // 
            this.botonDeModificacion.Location = new System.Drawing.Point(12, 170);
            this.botonDeModificacion.Name = "botonDeModificacion";
            this.botonDeModificacion.Size = new System.Drawing.Size(260, 30);
            this.botonDeModificacion.TabIndex = 4;
            this.botonDeModificacion.Text = "Modificación";
            this.botonDeModificacion.UseVisualStyleBackColor = true;
            this.botonDeModificacion.Click += new System.EventHandler(this.botonDeModificacion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonDeModificacion);
            this.Controls.Add(this.botonDeBaja);
            this.Controls.Add(this.botonDeAlta);
            this.Name = "Principal";
            this.Text = "Afiliados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDeAlta;
        private System.Windows.Forms.Button botonDeBaja;
        private System.Windows.Forms.Button botonDeModificacion;
    }
}