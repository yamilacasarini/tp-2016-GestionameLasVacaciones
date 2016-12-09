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
        public buscarTurno(int idProfesional)
        {
            InitializeComponent();
            int soyProfesional = idProfesional; // -1 en caso de que sea el admin el que lo solicita y no un profesional
            List<Especialidad> especialidades = TurnosManager.listarEspecialidades(soyProfesional);
            List <String> descripcionEsp = new List<String>();
            descripcionEsp.Add("");
            foreach (Especialidad esp in especialidades){
            descripcionEsp.Add(esp.descripcion);
            }
            cbEspecialidad.DataSource = descripcionEsp;
            btSeleccionar.Hide();

            if (soyProfesional > 0) {
                txApellido.Text = Sesion.getInstance().profesional.apellido;
                txNombre.Text = Sesion.getInstance().profesional.nombre;
                txApellido.Enabled = false;
                txNombre.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.soloNumeros(idText, "id"))
                {
                    this.dataGridView1.DataSource = TurnosManager.BuscarTurnos(txNombre.Text.Trim(), txApellido.Text.Trim(), cbEspecialidad.Text.Trim(), idText.Text.Trim());
                    btSeleccionar.Show();
                }
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
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

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
