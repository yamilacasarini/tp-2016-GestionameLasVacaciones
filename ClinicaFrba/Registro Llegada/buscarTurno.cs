using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{   

    public partial class buscarTurno : Form
    {
        public  int idTurno;
        public buscarTurno()
        {
            InitializeComponent();
            btSeleccionar.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txApellido.Text.Trim() != "" || txNombre.Text.Trim() != "" || txEspecialidad.Text.Trim() != "")
            {
               // this.dataGridView1.DataSource = LlegadaManager.BuscarTurnos(txApellido.Text.Trim(), txNombre.Text.Trim(),txEspecialidad.Text.Trim());
                btSeleccionar.Show();
            }
            else
            {
                MessageBox.Show("Ingrese al menos un dato");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
               
            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
            }
        }
    }
}
