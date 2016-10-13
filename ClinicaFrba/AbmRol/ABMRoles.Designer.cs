namespace ClinicaFrba.AbmRol
{
    partial class ABMRoles
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
            this.titulo = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titulo.Location = new System.Drawing.Point(76, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(123, 26);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "ABM-Roles";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCrear.Location = new System.Drawing.Point(34, 60);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(76, 30);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.button_crear_click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModificar.Location = new System.Drawing.Point(34, 132);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(76, 30);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.button_Modificar_click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEliminar.Location = new System.Drawing.Point(34, 199);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(76, 30);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // ABMRoles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.titulo);
            this.Name = "ABMRoles";
            this.Load += new System.EventHandler(this.ABMRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}