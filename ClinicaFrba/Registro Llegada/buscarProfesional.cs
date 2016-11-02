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
    public partial class buscarProfesional : Form
    {
        public buscarProfesional()
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
                this.dataGridView1.DataSource = llegadaMananger.BuscarProfesionales(txApellido.Text.Trim(), txNombre.Text.Trim(),txEspecialidad.Text.Trim()));
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
                mostrarTurno form = new mostrarTurno();
                form.profesional.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                form.profesional.especialidad = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                form.profesional.nombre = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                form.profesional.apellido = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
            }
        }
    }
}
