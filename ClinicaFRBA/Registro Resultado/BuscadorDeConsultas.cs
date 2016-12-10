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
namespace ClinicaFrba.Registro_Resultado
{
    public partial class BuscadorDeConsultas : Form
    {
        Consulta consultaSeleccionada;
        Int32 matriculaProfesional;
        public BuscadorDeConsultas(int matricula)
        {
            InitializeComponent();
            if (matricula != -1) {
                txtNombreProf.Text = Sesion.getInstance().profesional.nombre;
                txtApellidoProf.Text = Sesion.getInstance().profesional.apellido;
                txtNombreProf.Enabled = false;
                txtApellidoProf.Enabled = false;
            }
            matriculaProfesional = matricula;

        }
        public Consulta getConsulta() {
            Consulta consu = consultaSeleccionada;
            return consu;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscadorDeConsultas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

                if (matriculaProfesional == -1)
                {
                    dataGridView1.DataSource = ConsultasManager.BuscarConsulta(txtNombreProf.Text.Trim(), txtApellidoProf.Text.Trim(), txtNumPac.Text.Trim(), txtNumTurno.Text.Trim());
                }
                else
                {
                    dataGridView1.DataSource = ConsultasManager.BuscarConsulta(Sesion.getInstance().profesional.nombre, Sesion.getInstance().profesional.apellido, txtNumPac.Text.Trim(), txtNumTurno.Text.Trim());
                }
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                consultaSeleccionada = new Consulta();
                consultaSeleccionada.fecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);
                consultaSeleccionada.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                consultaSeleccionada.IdTurno = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                this.Close(); 
            }
            else {
                MessageBox.Show("Por favor seleccione una unica fila");
            }
        }
    }
}
