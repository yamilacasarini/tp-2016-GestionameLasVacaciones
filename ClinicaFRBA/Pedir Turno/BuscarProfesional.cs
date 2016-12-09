using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba.Pedir_Turno
{

    public partial class BuscarProfesional : Form
    {

        public BuscarProfesional()
        {
            InitializeComponent();
            List<Registro_Llegada.Especialidad> especialidades =Registro_Llegada.TurnosManager.listarEspecialidades(-1);
            List<String> descripcionEsp = new List<String>();
            descripcionEsp.Add("");
            foreach (Registro_Llegada.Especialidad esp in especialidades)
            {
                descripcionEsp.Add(esp.descripcion);
            }
            comboBox1.DataSource = descripcionEsp;
        }

        public Profesional profesional;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hola_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.soloNumeros(txMatricula, "matricula"))
                {
                    if (txMatricula.Text.Trim() == "") { txMatricula.Text = "-1"; }

                    this.dataGridView1.DataSource = ProfesionalManager.BuscarProfesionales(txNombre.Text.Trim(), txApellido.Text.Trim(), comboBox1.SelectedItem.ToString().Trim(), Convert.ToInt32(txMatricula.Text.Trim()));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                profesional = new Profesional();
                profesional.matricula = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                profesional.nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                profesional.apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                profesional.especialidad = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
                return;
            }
            this.Close();
        }

        private void BuscarProfesional_Load(object sender, EventArgs e)
        {

        }
    }

}
