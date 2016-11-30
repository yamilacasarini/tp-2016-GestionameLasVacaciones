namespace ClinicaFrba.Registro_Resultado
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
            this.txSintomas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDiagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTurno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sintomas (Máximo 255 caracteres)";
            // 
            // txSintomas
            // 
            this.txSintomas.Location = new System.Drawing.Point(202, 93);
            this.txSintomas.Multiline = true;
            this.txSintomas.Name = "txSintomas";
            this.txSintomas.Size = new System.Drawing.Size(160, 120);
            this.txSintomas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diagnostico (Máximo 255 caracteres)";
            // 
            // txDiagnostico
            // 
            this.txDiagnostico.Location = new System.Drawing.Point(12, 93);
            this.txDiagnostico.Multiline = true;
            this.txDiagnostico.Name = "txDiagnostico";
            this.txDiagnostico.Size = new System.Drawing.Size(184, 120);
            this.txDiagnostico.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de turno";
            // 
            // idTurno
            // 
            this.idTurno.Enabled = false;
            this.idTurno.Location = new System.Drawing.Point(132, 26);
            this.idTurno.Name = "idTurno";
            this.idTurno.Size = new System.Drawing.Size(135, 20);
            this.idTurno.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txDiagnostico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txSintomas);
            this.Name = "Principal";
            this.Text = "Registrar Resultado de atención";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSintomas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDiagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}