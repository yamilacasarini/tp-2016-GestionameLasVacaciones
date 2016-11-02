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
            this.label4.Text = "";
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

            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Llene el campo para realizar la busqueda");
            }
            else
            {
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
                int baja = RolManager.obtenerBaja(txtNombre.Text.Trim());
                if (baja == 0)
                {
                    this.label4.Text = "HABILITADO";
                }
                else
                {
                    if (baja == 1)
                        this.label4.Text = "INHABILITADO";
                }
            }
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

                DataGridViewSelectedRowCollection seleccion = this.dataGridView2.SelectedRows;
                foreach (DataGridViewRow funcionalidad in seleccion)
                {
                    RolManager.agregarRolYFuncionalidad(this.txtNombre.Text, Convert.ToString(funcionalidad.Cells[1].Value));
                }

        

                MessageBox.Show("Las funcionalidades han sido agregadas al rol exitosamente");
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
            }
            

        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            if(this.label4.Text == "HABILITADO")
            {
                MessageBox.Show("El Rol ya esta habilitado");
                }
            else
            {
                if(this.label4.Text == "INHABILITADO")
                {
                    MessageBox.Show("Se ha habilitado el rol");
                    RolManager.habilitarRol(txtNombre.Text.Trim());
                    this.label4.Text = "HABILITADO";
                }
            }
        }
    }
}
