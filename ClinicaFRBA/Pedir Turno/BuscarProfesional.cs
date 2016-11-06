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

    public partial class BuscarProfesional : Form
    {
        public int abrirCancelacion = 0;
        public BuscarProfesional()
        {
            InitializeComponent();
        }

        public Profesional profesional;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hola_Click_1(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (txMatricula.Text.Trim() == "") { txMatricula.Text = "-1"; }

                this.dataGridView1.DataSource = ProfesionalManager.BuscarProfesionales(txNombre.Text.Trim(), txApellido.Text.Trim(), txEspecialidad.Text.Trim(), Convert.ToInt32(txMatricula.Text.Trim()));
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
            if (abrirCancelacion == 1)
            {
                Cancelar_Atencion.CancelacionMedico cancelacion = new Cancelar_Atencion.CancelacionMedico(profesional.matricula, profesional.especialidad);
                cancelacion.ShowDialog();
            }
            this.Close();
        }

        private void BuscarProfesional_Load(object sender, EventArgs e)
        {

        }
        }
    
}
