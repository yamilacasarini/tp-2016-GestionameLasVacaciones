namespace ClinicaFrba.AbmRol
{
    partial class AltaRol
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
            this.labelFamiliar = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelFamiliar
            // 
            this.labelFamiliar.AutoSize = true;
            this.labelFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFamiliar.Location = new System.Drawing.Point(12, 9);
            this.labelFamiliar.Name = "labelFamiliar";
            this.labelFamiliar.Size = new System.Drawing.Size(96, 20);
            this.labelFamiliar.TabIndex = 47;
            this.labelFamiliar.Text = "Ingresar Rol";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 48;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelFamiliar);
            this.Name = "AltaRol";
            this.Text = "AltaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFamiliar;
        private System.Windows.Forms.ListBox listBox1;
    }
}