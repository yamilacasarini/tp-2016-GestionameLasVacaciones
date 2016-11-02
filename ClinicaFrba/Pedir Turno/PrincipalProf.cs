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

    public partial class PrincipalProf : Form
    {
        public PrincipalProf()
        {
            InitializeComponent();
        }

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
                ListarTurnos fafa = new ListarTurnos(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[3].Value.ToString());
                fafa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
            }
        }
        }
    
}
