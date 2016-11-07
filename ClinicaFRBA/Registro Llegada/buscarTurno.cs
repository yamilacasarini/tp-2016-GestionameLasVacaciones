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
        public Turno turnoSelect;
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
            if (txApellido.Text.Trim() != "" || txNombre.Text.Trim() != "" || txEspecialidad.Text.Trim() != "" || idText.Text.Trim() != "")
            {
                if (Validacion.soloNumeros(idText, "id"))
                {
                    this.dataGridView1.DataSource = TurnosManager.BuscarTurnos(txApellido.Text.Trim(), txNombre.Text.Trim(), txEspecialidad.Text.Trim(), idText.Text.Trim());
                    btSeleccionar.Show();
                }
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
                turnoSelect = new Turno();
                turnoSelect.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                turnoSelect.idProfesional = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                turnoSelect.especialidad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                turnoSelect.idPaciente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
            }
        }

        private void idText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
