namespace ClinicaFrba.Abm_Afiliado
{
    partial class modificarAfiliado
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.cBestadoCivil = new System.Windows.Forms.ComboBox();
            this.cBsexo = new System.Windows.Forms.ComboBox();
            this.cBtipoDocumento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txFamiliaresACargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btCambiarPlan = new System.Windows.Forms.Button();
            this.txPlanMedico = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 238);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 10, 19, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.Value = new System.DateTime(2016, 10, 19, 0, 0, 0, 0);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSalir.Location = new System.Drawing.Point(454, 362);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(76, 30);
            this.buttonSalir.TabIndex = 65;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAceptar.Location = new System.Drawing.Point(12, 362);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(76, 30);
            this.btAceptar.TabIndex = 64;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
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
            this.cBestadoCivil.Location = new System.Drawing.Point(219, 284);
            this.cBestadoCivil.Name = "cBestadoCivil";
            this.cBestadoCivil.Size = new System.Drawing.Size(199, 21);
            this.cBestadoCivil.TabIndex = 62;
            // 
            // cBsexo
            // 
            this.cBsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBsexo.FormattingEnabled = true;
            this.cBsexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cBsexo.Location = new System.Drawing.Point(219, 260);
            this.cBsexo.Name = "cBsexo";
            this.cBsexo.Size = new System.Drawing.Size(199, 21);
            this.cBsexo.TabIndex = 61;
            // 
            // cBtipoDocumento
            // 
            this.cBtipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBtipoDocumento.Enabled = false;
            this.cBtipoDocumento.FormattingEnabled = true;
            this.cBtipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "LI",
            "LC",
            "LD"});
            this.cBtipoDocumento.Location = new System.Drawing.Point(219, 105);
            this.cBtipoDocumento.Name = "cBtipoDocumento";
            this.cBtipoDocumento.Size = new System.Drawing.Size(199, 21);
            this.cBtipoDocumento.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(59, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "Familiares a cargo:";
            // 
            // txFamiliaresACargo
            // 
            this.txFamiliaresACargo.Location = new System.Drawing.Point(219, 308);
            this.txFamiliaresACargo.MaxLength = 2;
            this.txFamiliaresACargo.Name = "txFamiliaresACargo";
            this.txFamiliaresACargo.Size = new System.Drawing.Size(199, 20);
            this.txFamiliaresACargo.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(59, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Estado civil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(59, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(59, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Telefono:";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(219, 188);
            this.txTelefono.MaxLength = 15;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(199, 20);
            this.txTelefono.TabIndex = 53;
            // 
            // txMail
            // 
            this.txMail.Location = new System.Drawing.Point(219, 212);
            this.txMail.MaxLength = 100;
            this.txMail.Name = "txMail";
            this.txMail.Size = new System.Drawing.Size(199, 20);
            this.txMail.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(59, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Direccion:";
            // 
            // txDireccion
            // 
            this.txDireccion.Location = new System.Drawing.Point(219, 162);
            this.txDireccion.MaxLength = 100;
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.Size = new System.Drawing.Size(199, 20);
            this.txDireccion.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(59, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nro Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(59, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tipo Documento:";
            // 
            // txDocumento
            // 
            this.txDocumento.Enabled = false;
            this.txDocumento.Location = new System.Drawing.Point(219, 136);
            this.txDocumento.MaxLength = 10;
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(199, 20);
            this.txDocumento.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre:";
            // 
            // txApellido
            // 
            this.txApellido.Enabled = false;
            this.txApellido.Location = new System.Drawing.Point(219, 79);
            this.txApellido.MaxLength = 30;
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(199, 20);
            this.txApellido.TabIndex = 44;
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txNombre.Location = new System.Drawing.Point(219, 53);
            this.txNombre.MaxLength = 30;
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(199, 20);
            this.txNombre.TabIndex = 43;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(59, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(59, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mail:";
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBuscar.Location = new System.Drawing.Point(279, 362);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(160, 30);
            this.btBuscar.TabIndex = 69;
            this.btBuscar.Text = "Buscar Afiliado";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(59, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Plan Medico:";
            // 
            // btCambiarPlan
            // 
            this.btCambiarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btCambiarPlan.Location = new System.Drawing.Point(369, 334);
            this.btCambiarPlan.Name = "btCambiarPlan";
            this.btCambiarPlan.Size = new System.Drawing.Size(115, 22);
            this.btCambiarPlan.TabIndex = 72;
            this.btCambiarPlan.Text = "Cambiar Plan";
            this.btCambiarPlan.UseVisualStyleBackColor = true;
            this.btCambiarPlan.Click += new System.EventHandler(this.btCambiarPlan_Click_1);
            // 
            // txPlanMedico
            // 
            this.txPlanMedico.Location = new System.Drawing.Point(219, 334);
            this.txPlanMedico.MaxLength = 2;
            this.txPlanMedico.Name = "txPlanMedico";
            this.txPlanMedico.Size = new System.Drawing.Size(144, 20);
            this.txPlanMedico.TabIndex = 73;
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAgregar.Location = new System.Drawing.Point(94, 362);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(164, 30);
            this.btAgregar.TabIndex = 74;
            this.btAgregar.Text = "Agregar Familiar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // modificarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 404);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txPlanMedico);
            this.Controls.Add(this.btCambiarPlan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cBestadoCivil);
            this.Controls.Add(this.cBsexo);
            this.Controls.Add(this.cBtipoDocumento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txFamiliaresACargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txTelefono);
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
            this.Name = "modificarAfiliado";
            this.Text = "modificarAfiliado";
            this.Load += new System.EventHandler(this.modificarAfiliado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.ComboBox cBestadoCivil;
        private System.Windows.Forms.ComboBox cBsexo;
        private System.Windows.Forms.ComboBox cBtipoDocumento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txFamiliaresACargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btCambiarPlan;
        private System.Windows.Forms.TextBox txPlanMedico;
        private System.Windows.Forms.Button btAgregar;

    }
}