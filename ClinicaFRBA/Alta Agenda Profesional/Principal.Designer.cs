namespace ClinicaFrba.Alta_Agenda_Profesional
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
            this.profesional = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.anioInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mesInicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DiaInicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diaFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mesFinal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.anioFinal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listaHorasInicio = new System.Windows.Forms.ComboBox();
            this.listaMinutosInicio = new System.Windows.Forms.ComboBox();
            this.listaMinutosFinal = new System.Windows.Forms.ComboBox();
            this.listaHorasFinal = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.diaSemanaInicio = new System.Windows.Forms.ComboBox();
            this.diaSemanaFinal = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesional:";
            // 
            // profesional
            // 
            this.profesional.AutoSize = true;
            this.profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesional.Location = new System.Drawing.Point(110, 20);
            this.profesional.Name = "profesional";
            this.profesional.Size = new System.Drawing.Size(0, 20);
            this.profesional.TabIndex = 1;
            this.profesional.Click += new System.EventHandler(this.label2_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(356, 17);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 27);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese fecha de inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Año:";
            // 
            // anioInicio
            // 
            this.anioInicio.Location = new System.Drawing.Point(60, 88);
            this.anioInicio.Name = "anioInicio";
            this.anioInicio.Size = new System.Drawing.Size(76, 20);
            this.anioInicio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mes:";
            // 
            // mesInicio
            // 
            this.mesInicio.Location = new System.Drawing.Point(191, 88);
            this.mesInicio.Name = "mesInicio";
            this.mesInicio.Size = new System.Drawing.Size(76, 20);
            this.mesInicio.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dia:";
            // 
            // DiaInicio
            // 
            this.DiaInicio.Location = new System.Drawing.Point(316, 88);
            this.DiaInicio.Name = "DiaInicio";
            this.DiaInicio.Size = new System.Drawing.Size(76, 20);
            this.DiaInicio.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ingrese fecha final:";
            // 
            // diaFinal
            // 
            this.diaFinal.Location = new System.Drawing.Point(316, 154);
            this.diaFinal.Name = "diaFinal";
            this.diaFinal.Size = new System.Drawing.Size(76, 20);
            this.diaFinal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dia:";
            // 
            // mesFinal
            // 
            this.mesFinal.Location = new System.Drawing.Point(191, 154);
            this.mesFinal.Name = "mesFinal";
            this.mesFinal.Size = new System.Drawing.Size(76, 20);
            this.mesFinal.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mes:";
            // 
            // anioFinal
            // 
            this.anioFinal.Location = new System.Drawing.Point(60, 154);
            this.anioFinal.Name = "anioFinal";
            this.anioFinal.Size = new System.Drawing.Size(76, 20);
            this.anioFinal.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Año:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Hora inicio de jornada (24hs):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(297, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Hora fin de jornada (24hs):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Dia inicial:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(224, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Dia Final:";
            // 
            // listaHorasInicio
            // 
            this.listaHorasInicio.FormattingEnabled = true;
            this.listaHorasInicio.Location = new System.Drawing.Point(233, 193);
            this.listaHorasInicio.Name = "listaHorasInicio";
            this.listaHorasInicio.Size = new System.Drawing.Size(60, 21);
            this.listaHorasInicio.TabIndex = 27;
            // 
            // listaMinutosInicio
            // 
            this.listaMinutosInicio.FormattingEnabled = true;
            this.listaMinutosInicio.Location = new System.Drawing.Point(316, 193);
            this.listaMinutosInicio.Name = "listaMinutosInicio";
            this.listaMinutosInicio.Size = new System.Drawing.Size(60, 21);
            this.listaMinutosInicio.TabIndex = 28;
            // 
            // listaMinutosFinal
            // 
            this.listaMinutosFinal.FormattingEnabled = true;
            this.listaMinutosFinal.Location = new System.Drawing.Point(316, 229);
            this.listaMinutosFinal.Name = "listaMinutosFinal";
            this.listaMinutosFinal.Size = new System.Drawing.Size(60, 21);
            this.listaMinutosFinal.TabIndex = 31;
            // 
            // listaHorasFinal
            // 
            this.listaHorasFinal.FormattingEnabled = true;
            this.listaHorasFinal.Location = new System.Drawing.Point(233, 229);
            this.listaHorasFinal.Name = "listaHorasFinal";
            this.listaHorasFinal.Size = new System.Drawing.Size(60, 21);
            this.listaHorasFinal.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(297, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = ":";
            // 
            // diaSemanaInicio
            // 
            this.diaSemanaInicio.FormattingEnabled = true;
            this.diaSemanaInicio.Location = new System.Drawing.Point(88, 265);
            this.diaSemanaInicio.Name = "diaSemanaInicio";
            this.diaSemanaInicio.Size = new System.Drawing.Size(130, 21);
            this.diaSemanaInicio.TabIndex = 32;
            // 
            // diaSemanaFinal
            // 
            this.diaSemanaFinal.FormattingEnabled = true;
            this.diaSemanaFinal.Location = new System.Drawing.Point(301, 265);
            this.diaSemanaFinal.Name = "diaSemanaFinal";
            this.diaSemanaFinal.Size = new System.Drawing.Size(130, 21);
            this.diaSemanaFinal.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(154, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.diaSemanaFinal);
            this.Controls.Add(this.diaSemanaInicio);
            this.Controls.Add(this.listaMinutosFinal);
            this.Controls.Add(this.listaHorasFinal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listaMinutosInicio);
            this.Controls.Add(this.listaHorasInicio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.diaFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mesFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.anioFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DiaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mesInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anioInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.profesional);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Alta Agenda de Profesional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label profesional;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox anioInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mesInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DiaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diaFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mesFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anioFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox listaHorasInicio;
        private System.Windows.Forms.ComboBox listaMinutosInicio;
        private System.Windows.Forms.ComboBox listaMinutosFinal;
        private System.Windows.Forms.ComboBox listaHorasFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox diaSemanaInicio;
        private System.Windows.Forms.ComboBox diaSemanaFinal;
        private System.Windows.Forms.Button button2;
    }
}