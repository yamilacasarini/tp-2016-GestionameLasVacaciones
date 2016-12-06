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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Afiliado ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modificaciones de Plan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonDeModificacion);
            this.Controls.Add(this.botonDeBaja);
            this.Controls.Add(this.botonDeAlta);
            this.Name = "Principal";
            this.Text = "Afiliados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDeAlta;
        private System.Windows.Forms.Button botonDeBaja;
        private System.Windows.Forms.Button botonDeModificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}