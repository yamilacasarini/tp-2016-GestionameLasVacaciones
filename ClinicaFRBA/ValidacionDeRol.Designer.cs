namespace ClinicaFrba
{
    partial class ValidacionDeRol
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
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FuncionalidadComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RolComboBox
            // 
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Location = new System.Drawing.Point(12, 66);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(260, 21);
            this.RolComboBox.TabIndex = 0;
            this.RolComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el Rol";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(77, 196);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(116, 40);
            this.BotonAceptar.TabIndex = 2;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione la funcionalidad";
            // 
            // FuncionalidadComboBox
            // 
            this.FuncionalidadComboBox.FormattingEnabled = true;
            this.FuncionalidadComboBox.Location = new System.Drawing.Point(12, 144);
            this.FuncionalidadComboBox.Name = "FuncionalidadComboBox";
            this.FuncionalidadComboBox.Size = new System.Drawing.Size(260, 21);
            this.FuncionalidadComboBox.TabIndex = 3;
            // 
            // ValidacionDeRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FuncionalidadComboBox);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RolComboBox);
            this.Name = "ValidacionDeRol";
            this.Text = "Seleccionar Rol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FuncionalidadComboBox;

    }
}