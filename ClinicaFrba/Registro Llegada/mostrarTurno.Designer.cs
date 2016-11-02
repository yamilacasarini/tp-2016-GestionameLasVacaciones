namespace ClinicaFrba.Registro_Llegada
{
    partial class mostrarTurno
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
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(159, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Busqueda de turno";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCancelar.Location = new System.Drawing.Point(374, 317);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(128, 33);
            this.btCancelar.TabIndex = 39;
            this.btCancelar.Text = "Salir";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSeleccionar.Location = new System.Drawing.Point(39, 317);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(128, 33);
            this.btSeleccionar.TabIndex = 38;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 148);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(137, 108);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(38, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Documento";
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(137, 82);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(100, 20);
            this.txApellido.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Apellido";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(137, 56);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre";
            // 
            // mostrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 369);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mostrarTurno";
            this.Text = "mostrarTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label2;
    }
}