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
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = RolManager.mostrarTodasLasFuncionalidades();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text) || this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor introduzca un nombre o seleccione una funcionalidad para agregar");
                
            }
            else
            {
                DataGridViewSelectedRowCollection seleccion = this.dataGridView1.SelectedRows;
                if (!RolManager.existeElRol(txtNombre.Text.Trim()))
                    RolManager.agregarRol(this.txtNombre.Text.Trim(), login.usuario.ToString());
                else
                {
                    if (RolManager.obtenerBaja(txtNombre.Text.Trim()) == 1)
                    {
                        MessageBox.Show("El rol ya existe");
                        return;
                    }

                }
                foreach (DataGridViewRow funcionalidad in seleccion)
                {
                    RolManager.agregarFuncionalidad(this.txtNombre.Text.Trim(), Convert.ToString(funcionalidad.Cells[1].Value));
                }

                MessageBox.Show("Se agregaron las funcionalidades, dirijase a modificacion en caso de desearlo");
                this.button2.Enabled = false;
                this.dataGridView1.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
                return;
            }
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {

        }
    }
}
