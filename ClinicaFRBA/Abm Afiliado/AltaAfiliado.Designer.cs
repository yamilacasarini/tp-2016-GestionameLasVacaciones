﻿namespace ClinicaFrba.Abm_Afiliado
{
    partial class AltaAfiliado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cBtipoDocumento = new System.Windows.Forms.ComboBox();
            this.cBsexo = new System.Windows.Forms.ComboBox();
            this.cBestadoCivil = new System.Windows.Forms.ComboBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cBplanMedico = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.Label();
            this.btAgregarFam = new System.Windows.Forms.Button();
            this.labelFamiliar = new System.Windows.Forms.Label();
            this.txFamiliaresACargo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txFamiliaresACargo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(171, 104);
            this.txApellido.MaxLength = 30;
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(200, 20);
            this.txApellido.TabIndex = 11;
            this.txApellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txNombre
            // 
            this.txNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txNombre.Location = new System.Drawing.Point(171, 79);
            this.txNombre.MaxLength = 30;
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(200, 20);
            this.txNombre.TabIndex = 10;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo Documento:";
            // 
            // txDocumento
            // 
            this.txDocumento.Location = new System.Drawing.Point(171, 155);
            this.txDocumento.MaxLength = 10;
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(78, 20);
            this.txDocumento.TabIndex = 15;
            this.txDocumento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nro Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Direccion:";
            // 
            // txDireccion
            // 
            this.txDireccion.Location = new System.Drawing.Point(171, 180);
            this.txDireccion.MaxLength = 100;
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.Size = new System.Drawing.Size(200, 20);
            this.txDireccion.TabIndex = 18;
            this.txDireccion.TextChanged += new System.EventHandler(this.txDireccion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(6, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mail:";
            // 
            // txMail
            // 
            this.txMail.Location = new System.Drawing.Point(171, 230);
            this.txMail.MaxLength = 100;
            this.txMail.Name = "txMail";
            this.txMail.Size = new System.Drawing.Size(200, 20);
            this.txMail.TabIndex = 20;
            this.txMail.TextChanged += new System.EventHandler(this.txMail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Telefono:";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(171, 205);
            this.txTelefono.MaxLength = 15;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(200, 20);
            this.txTelefono.TabIndex = 22;
            this.txTelefono.TextChanged += new System.EventHandler(this.txTelefono_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(6, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Estado civil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(6, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(6, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Familiares a cargo:";
            // 
            // cBtipoDocumento
            // 
            this.cBtipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBtipoDocumento.FormattingEnabled = true;
            this.cBtipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "LI",
            "LC",
            "LD"});
            this.cBtipoDocumento.Location = new System.Drawing.Point(171, 130);
            this.cBtipoDocumento.Name = "cBtipoDocumento";
            this.cBtipoDocumento.Size = new System.Drawing.Size(78, 21);
            this.cBtipoDocumento.TabIndex = 36;
            this.cBtipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cBtipoDocumento_SelectedIndexChanged);
            // 
            // cBsexo
            // 
            this.cBsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBsexo.FormattingEnabled = true;
            this.cBsexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cBsexo.Location = new System.Drawing.Point(171, 280);
            this.cBsexo.Name = "cBsexo";
            this.cBsexo.Size = new System.Drawing.Size(78, 21);
            this.cBsexo.TabIndex = 37;
            this.cBsexo.SelectedIndexChanged += new System.EventHandler(this.cBsexo_SelectedIndexChanged);
            // 
            // cBestadoCivil
            // 
            this.cBestadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBestadoCivil.FormattingEnabled = true;
            this.cBestadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Concubinato",
            "Divorciado"});
            this.cBestadoCivil.Location = new System.Drawing.Point(171, 306);
            this.cBestadoCivil.Name = "cBestadoCivil";
            this.cBestadoCivil.Size = new System.Drawing.Size(78, 21);
            this.cBestadoCivil.TabIndex = 38;
            this.cBestadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalir.Location = new System.Drawing.Point(327, 400);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(76, 30);
            this.buttonSalir.TabIndex = 41;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAgregar.Location = new System.Drawing.Point(29, 400);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(76, 30);
            this.btAgregar.TabIndex = 40;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 255);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.Value = new System.DateTime(2016, 10, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(6, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Plan Medico:";
            // 
            // cBplanMedico
            // 
            this.cBplanMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBplanMedico.FormattingEnabled = true;
            this.cBplanMedico.Location = new System.Drawing.Point(171, 362);
            this.cBplanMedico.Name = "cBplanMedico";
            this.cBplanMedico.Size = new System.Drawing.Size(200, 21);
            this.cBplanMedico.TabIndex = 39;
            this.cBplanMedico.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "ID:";
            // 
            // txId
            // 
            this.txId.AutoSize = true;
            this.txId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txId.Location = new System.Drawing.Point(192, 51);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(0, 20);
            this.txId.TabIndex = 44;
            // 
            // btAgregarFam
            // 
            this.btAgregarFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAgregarFam.Location = new System.Drawing.Point(146, 400);
            this.btAgregarFam.Name = "btAgregarFam";
            this.btAgregarFam.Size = new System.Drawing.Size(146, 30);
            this.btAgregarFam.TabIndex = 45;
            this.btAgregarFam.Text = "Agregar Familiar";
            this.btAgregarFam.UseVisualStyleBackColor = true;
            this.btAgregarFam.Click += new System.EventHandler(this.btAgregarFam_Click);
            // 
            // labelFamiliar
            // 
            this.labelFamiliar.AutoSize = true;
            this.labelFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFamiliar.Location = new System.Drawing.Point(25, 22);
            this.labelFamiliar.Name = "labelFamiliar";
            this.labelFamiliar.Size = new System.Drawing.Size(170, 20);
            this.labelFamiliar.TabIndex = 46;
            this.labelFamiliar.Text = "Ingresando familiar de:";
            // 
            // txFamiliaresACargo
            // 
            this.txFamiliaresACargo.Location = new System.Drawing.Point(171, 337);
            this.txFamiliaresACargo.Name = "txFamiliaresACargo";
            this.txFamiliaresACargo.Size = new System.Drawing.Size(78, 20);
            this.txFamiliaresACargo.TabIndex = 76;
            // 
            // AltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 443);
            this.Controls.Add(this.txFamiliaresACargo);
            this.Controls.Add(this.labelFamiliar);
            this.Controls.Add(this.btAgregarFam);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cBplanMedico);
            this.Controls.Add(this.cBestadoCivil);
            this.Controls.Add(this.cBsexo);
            this.Controls.Add(this.cBtipoDocumento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txApellido);
            this.Controls.Add(this.txNombre);
            this.Name = "AltaAfiliado";
            this.Text = "Alta  Afiliado";
            this.Load += new System.EventHandler(this.AltaAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txFamiliaresACargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cBtipoDocumento;
        private System.Windows.Forms.ComboBox cBsexo;
        private System.Windows.Forms.ComboBox cBestadoCivil;
      //  private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBplanMedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txId;
        private System.Windows.Forms.Button btAgregarFam;
        private System.Windows.Forms.Label labelFamiliar;
        private System.Windows.Forms.NumericUpDown txFamiliaresACargo;
    }
}