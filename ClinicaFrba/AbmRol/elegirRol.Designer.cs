namespace ClinicaFrba.AbmRol
{
    partial class crearRol
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvFuncionalidadesAgregadas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesAgregadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(203, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(269, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 46);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(269, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 46);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionalidadesAgregadas
            // 
            this.dgvFuncionalidadesAgregadas.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvFuncionalidadesAgregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidadesAgregadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionalidadesAgregadas.Location = new System.Drawing.Point(350, 56);
            this.dgvFuncionalidadesAgregadas.Name = "dgvFuncionalidadesAgregadas";
            this.dgvFuncionalidadesAgregadas.ReadOnly = true;
            this.dgvFuncionalidadesAgregadas.Size = new System.Drawing.Size(245, 297);
            this.dgvFuncionalidadesAgregadas.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(478, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 31);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(320, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 31);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(11, 56);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.ReadOnly = true;
            this.dgvFuncionalidades.Size = new System.Drawing.Size(252, 297);
            this.dgvFuncionalidades.TabIndex = 13;
            this.dgvFuncionalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionalidades_CellContentClick);
            // 
            // crearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 418);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvFuncionalidadesAgregadas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvFuncionalidades);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "crearRol";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.crearRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesAgregadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvFuncionalidadesAgregadas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
    }
}