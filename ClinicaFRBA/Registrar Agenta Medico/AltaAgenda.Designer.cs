namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class AltaAgenda
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
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etiquetaIDMedico = new System.Windows.Forms.Label();
            this.horaYDiaDesce = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboSemanaDesde = new System.Windows.Forms.ComboBox();
            this.comboSemanaHasta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.horaYDiaHasta = new System.Windows.Forms.Label();
            this.SemanaDesde = new System.Windows.Forms.Label();
            this.SemanaHasta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(197, 25);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 0;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Profesional";
            // 
            // etiquetaIDMedico
            // 
            this.etiquetaIDMedico.AutoSize = true;
            this.etiquetaIDMedico.Location = new System.Drawing.Point(119, 30);
            this.etiquetaIDMedico.Name = "etiquetaIDMedico";
            this.etiquetaIDMedico.Size = new System.Drawing.Size(0, 13);
            this.etiquetaIDMedico.TabIndex = 2;
            // 
            // horaYDiaDesce
            // 
            this.horaYDiaDesce.Location = new System.Drawing.Point(25, 86);
            this.horaYDiaDesce.Name = "horaYDiaDesce";
            this.horaYDiaDesce.Size = new System.Drawing.Size(225, 20);
            this.horaYDiaDesce.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(25, 133);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // comboSemanaDesde
            // 
            this.comboSemanaDesde.FormattingEnabled = true;
            this.comboSemanaDesde.Location = new System.Drawing.Point(25, 180);
            this.comboSemanaDesde.Name = "comboSemanaDesde";
            this.comboSemanaDesde.Size = new System.Drawing.Size(225, 21);
            this.comboSemanaDesde.TabIndex = 5;
            // 
            // comboSemanaHasta
            // 
            this.comboSemanaHasta.FormattingEnabled = true;
            this.comboSemanaHasta.Location = new System.Drawing.Point(25, 228);
            this.comboSemanaHasta.Name = "comboSemanaHasta";
            this.comboSemanaHasta.Size = new System.Drawing.Size(225, 21);
            this.comboSemanaHasta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia del año y Hora desde";
            // 
            // horaYDiaHasta
            // 
            this.horaYDiaHasta.AutoSize = true;
            this.horaYDiaHasta.Location = new System.Drawing.Point(25, 113);
            this.horaYDiaHasta.Name = "horaYDiaHasta";
            this.horaYDiaHasta.Size = new System.Drawing.Size(124, 13);
            this.horaYDiaHasta.TabIndex = 8;
            this.horaYDiaHasta.Text = "Dia del año y Hora hasta";
            // 
            // SemanaDesde
            // 
            this.SemanaDesde.AutoSize = true;
            this.SemanaDesde.Location = new System.Drawing.Point(28, 160);
            this.SemanaDesde.Name = "SemanaDesde";
            this.SemanaDesde.Size = new System.Drawing.Size(127, 13);
            this.SemanaDesde.TabIndex = 9;
            this.SemanaDesde.Text = "Inicio de Semana Laboral";
            // 
            // SemanaHasta
            // 
            this.SemanaHasta.AutoSize = true;
            this.SemanaHasta.Location = new System.Drawing.Point(28, 208);
            this.SemanaHasta.Name = "SemanaHasta";
            this.SemanaHasta.Size = new System.Drawing.Size(116, 13);
            this.SemanaHasta.TabIndex = 10;
            this.SemanaHasta.Text = "Fin de Semana Laboral";
            // 
            // AltaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 265);
            this.Controls.Add(this.SemanaHasta);
            this.Controls.Add(this.SemanaDesde);
            this.Controls.Add(this.horaYDiaHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSemanaHasta);
            this.Controls.Add(this.comboSemanaDesde);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.horaYDiaDesce);
            this.Controls.Add(this.etiquetaIDMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonBuscar);
            this.Name = "AltaAgenda";
            this.Text = "Nueva Agenda Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etiquetaIDMedico;
        private System.Windows.Forms.DateTimePicker horaYDiaDesce;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboSemanaDesde;
        private System.Windows.Forms.ComboBox comboSemanaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label horaYDiaHasta;
        private System.Windows.Forms.Label SemanaDesde;
        private System.Windows.Forms.Label SemanaHasta;
    }
}