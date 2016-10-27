namespace ClinicaFrba.Abm_Afiliado
{
    partial class cambiarPlan
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.cBplanMedico = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalir.Location = new System.Drawing.Point(266, 111);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(76, 30);
            this.buttonSalir.TabIndex = 67;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAceptar.Location = new System.Drawing.Point(57, 111);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(76, 30);
            this.buttonAceptar.TabIndex = 66;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // cBplanMedico
            // 
            this.cBplanMedico.FormattingEnabled = true;
            this.cBplanMedico.Location = new System.Drawing.Point(117, 25);
            this.cBplanMedico.Name = "cBplanMedico";
            this.cBplanMedico.Size = new System.Drawing.Size(121, 21);
            this.cBplanMedico.TabIndex = 65;
            this.cBplanMedico.SelectedIndexChanged += new System.EventHandler(this.cBplanMedico_SelectedIndexChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Plan Medico:";
            // 
            // txMotivo
            // 
            this.txMotivo.AutoSize = true;
            this.txMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txMotivo.Location = new System.Drawing.Point(12, 56);
            this.txMotivo.Name = "txMotivo";
            this.txMotivo.Size = new System.Drawing.Size(59, 20);
            this.txMotivo.TabIndex = 45;
            this.txMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMotivo.Location = new System.Drawing.Point(82, 56);
            this.txtMotivo.MaxLength = 30;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(304, 20);
            this.txtMotivo.TabIndex = 43;
            // 
            // cambiarPlanMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 180);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.cBplanMedico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Name = "cambiarPlanMedico";
            this.Text = "cambiarPlanMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox cBplanMedico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}