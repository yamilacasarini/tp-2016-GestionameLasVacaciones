namespace ClinicaFrba.Cancelar_Atencion
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonDeModificacion = new System.Windows.Forms.Button();
            this.botonDeBaja = new System.Windows.Forms.Button();
            this.botonDeAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cancelar Atencion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // botonDeModificacion
            // 
            this.botonDeModificacion.Location = new System.Drawing.Point(12, 165);
            this.botonDeModificacion.Name = "botonDeModificacion";
            this.botonDeModificacion.Size = new System.Drawing.Size(260, 30);
            this.botonDeModificacion.TabIndex = 9;
            this.botonDeModificacion.Text = "Modificación";
            this.botonDeModificacion.UseVisualStyleBackColor = true;
            // 
            // botonDeBaja
            // 
            this.botonDeBaja.Location = new System.Drawing.Point(12, 110);
            this.botonDeBaja.Name = "botonDeBaja";
            this.botonDeBaja.Size = new System.Drawing.Size(260, 30);
            this.botonDeBaja.TabIndex = 8;
            this.botonDeBaja.Text = "Baja";
            this.botonDeBaja.UseVisualStyleBackColor = true;
            // 
            // botonDeAlta
            // 
            this.botonDeAlta.Location = new System.Drawing.Point(12, 61);
            this.botonDeAlta.Name = "botonDeAlta";
            this.botonDeAlta.Size = new System.Drawing.Size(260, 30);
            this.botonDeAlta.TabIndex = 7;
            this.botonDeAlta.Text = "Alta";
            this.botonDeAlta.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonDeModificacion);
            this.Controls.Add(this.botonDeBaja);
            this.Controls.Add(this.botonDeAlta);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonDeModificacion;
        private System.Windows.Forms.Button botonDeBaja;
        private System.Windows.Forms.Button botonDeAlta;
    }
}