namespace ClinicaFrba.Compra_Bono
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.etiquetaPaciente = new System.Windows.Forms.Label();
            this.EtiquetaPlan = new System.Windows.Forms.Label();
            this.etiquetaMonto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(112, 187);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 4;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(132, 105);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 20);
            this.cantidad.TabIndex = 5;
            this.cantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // etiquetaPaciente
            // 
            this.etiquetaPaciente.AutoSize = true;
            this.etiquetaPaciente.Location = new System.Drawing.Point(175, 39);
            this.etiquetaPaciente.Name = "etiquetaPaciente";
            this.etiquetaPaciente.Size = new System.Drawing.Size(0, 13);
            this.etiquetaPaciente.TabIndex = 6;
            // 
            // EtiquetaPlan
            // 
            this.EtiquetaPlan.AutoSize = true;
            this.EtiquetaPlan.Location = new System.Drawing.Point(175, 72);
            this.EtiquetaPlan.Name = "EtiquetaPlan";
            this.EtiquetaPlan.Size = new System.Drawing.Size(0, 13);
            this.EtiquetaPlan.TabIndex = 7;
            // 
            // etiquetaMonto
            // 
            this.etiquetaMonto.AutoSize = true;
            this.etiquetaMonto.Location = new System.Drawing.Point(175, 145);
            this.etiquetaMonto.Name = "etiquetaMonto";
            this.etiquetaMonto.Size = new System.Drawing.Size(0, 13);
            this.etiquetaMonto.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.etiquetaMonto);
            this.Controls.Add(this.EtiquetaPlan);
            this.Controls.Add(this.etiquetaPaciente);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Comprar Bonos";
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label etiquetaPaciente;
        private System.Windows.Forms.Label EtiquetaPlan;
        private System.Windows.Forms.Label etiquetaMonto;
        private System.Windows.Forms.Button button1;
    }
}