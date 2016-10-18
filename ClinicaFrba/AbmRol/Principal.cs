using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            label_nombre.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button_crear_click(object sender, EventArgs e)
        {
            crearRol newForm = new crearRol();
            newForm.Show();
            this.Close();
        }

        private void button_Modificar_click(object sender, EventArgs e)
        {

        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ABMRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
