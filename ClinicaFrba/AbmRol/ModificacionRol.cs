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
    public partial class ModificacionRol : Form
    {
        public ModificacionRol()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {
                   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
            this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
           
            }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (this.dataGridView1.SelectedRows.Count)
            {
                case 0:
                    MessageBox.Show("Seleccione una funcionalidad");
                    break;
                case 1:
                    RolManager.eliminarFuncionalidad(txtNombre.Text.Trim(),
                        Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
                MessageBox.Show("Se ha eliminado la funcionalidad indicada");
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
                    break;
                default:
                    MessageBox.Show("Selecciona de a una funcionalidad");
                    break;

            }
                
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una funcionalidad para agregar");
            }
            else
            {
                for (int i = 0; i < this.dataGridView2.SelectedRows.Count; i++)
                    RolManager.agregarRolYFuncionalidad(this.txtNombre.Text, Convert.ToString(this.dataGridView2.Rows[i].Cells[1].Value));

                MessageBox.Show("Las funcionalidades han sido agregadas al rol exitosamente");
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
            }
            

        }
    }
}
