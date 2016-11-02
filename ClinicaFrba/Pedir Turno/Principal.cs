using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (txMatricula.Text.Trim() == "") { txMatricula.Text = "-1"; }

                this.dataGridView1.DataSource = ProfesionalManager.BuscarProfesionales(txNombre.Text.Trim(), txApellido.Text.Trim(), txEspecialidad.Text.Trim(), Convert.ToInt32(txMatricula));
            }
                
            else

            {
                MessageBox.Show("Ingrese al menos un campo");
            }
        }
        bool validarDatos()
        {
            return txNombre.Text.Trim() != "" || txApellido.Text.Trim() != "" || txMatricula.Text.Trim() != "" || txEspecialidad.Text.Trim() != "" ;
        }
    }
    }
}
