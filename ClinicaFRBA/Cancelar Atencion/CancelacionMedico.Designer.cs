namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelacionMedico
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.dataAgenda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDia = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.MaskedTextBox();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.horaInicio = new System.Windows.Forms.TextBox();
            this.minutosInicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minutosFinal = new System.Windows.Forms.TextBox();
            this.horaFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Motivo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(90, 12);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(347, 51);
            this.txtMotivo.TabIndex = 57;
            this.txtMotivo.Text = "";
            // 
            // dataAgenda
            // 
            this.dataAgenda.AllowUserToAddRows = false;
            this.dataAgenda.AllowUserToDeleteRows = false;
            this.dataAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAgenda.Location = new System.Drawing.Point(54, 107);
            this.dataAgenda.Name = "dataAgenda";
            this.dataAgenda.ReadOnly = true;
            this.dataAgenda.Size = new System.Drawing.Size(383, 169);
            this.dataAgenda.TabIndex = 58;
            this.dataAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAgenda_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Agenda del Medico";
            // 
            // btnDia
            // 
            this.btnDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDia.Location = new System.Drawing.Point(31, 337);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(144, 34);
            this.btnDia.TabIndex = 60;
            this.btnDia.Text = "Cancelar Día";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDia
            // 
            this.txtDia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDia.Location = new System.Drawing.Point(254, 346);
            this.txtDia.Mask = "00/00/0000";
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(79, 20);
            this.txtDia.TabIndex = 61;
            this.txtDia.ValidatingType = typeof(System.DateTime);
            this.txtDia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPeriodo.Location = new System.Drawing.Point(31, 421);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(144, 34);
            this.btnPeriodo.TabIndex = 62;
            this.btnPeriodo.Text = "Cancelar Período";
            this.btnPeriodo.UseVisualStyleBackColor = true;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesde.Location = new System.Drawing.Point(270, 406);
            this.txtDesde.Mask = "00/00/0000";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(79, 20);
            this.txtDesde.TabIndex = 63;
            this.txtDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.BackColor = System.Drawing.SystemColors.Window;
            this.txtHasta.Location = new System.Drawing.Point(270, 443);
            this.txtHasta.Mask = "00/00/0000";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(79, 20);
            this.txtHasta.TabIndex = 66;
            this.txtHasta.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Día";
            // 
            // horaInicio
            // 
            this.horaInicio.Location = new System.Drawing.Point(355, 406);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Size = new System.Drawing.Size(40, 20);
            this.horaInicio.TabIndex = 69;
            // 
            // minutosInicio
            // 
            this.minutosInicio.Location = new System.Drawing.Point(414, 406);
            this.minutosInicio.Name = "minutosInicio";
            this.minutosInicio.Size = new System.Drawing.Size(40, 20);
            this.minutosInicio.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = ":";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = ":";
            // 
            // minutosFinal
            // 
            this.minutosFinal.Location = new System.Drawing.Point(414, 443);
            this.minutosFinal.Name = "minutosFinal";
            this.minutosFinal.Size = new System.Drawing.Size(40, 20);
            this.minutosFinal.TabIndex = 73;
            // 
            // horaFinal
            // 
            this.horaFinal.Location = new System.Drawing.Point(355, 443);
            this.horaFinal.Name = "horaFinal";
            this.horaFinal.Size = new System.Drawing.Size(40, 20);
            this.horaFinal.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "ó";
            // 
            // CancelacionMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 475);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minutosFinal);
            this.Controls.Add(this.horaFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minutosInicio);
            this.Controls.Add(this.horaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.btnPeriodo);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataAgenda);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label3);
            this.Name = "CancelacionMedico";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.CancelacionMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.DataGridView dataAgenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.MaskedTextBox txtDia;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox horaInicio;
        private System.Windows.Forms.TextBox minutosInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minutosFinal;
        private System.Windows.Forms.TextBox horaFinal;
        private System.Windows.Forms.Label label6;
    }
}