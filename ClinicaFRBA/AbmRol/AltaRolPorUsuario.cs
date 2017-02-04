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
    public partial class AltaRolPorUsuario : Form
    {
        public Abm_Afiliado.Afiliado afiliado;
        public AltaRolPorUsuario()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Abm_Afiliado.BuscarAfiliados buscadorAfiliado = new Abm_Afiliado.BuscarAfiliados();
            buscadorAfiliado.ShowDialog();
            afiliado = buscadorAfiliado.afiliadoBuscado;
            if (afiliado != null)
            {
                this.Nombre.Text = afiliado.nombre;
                this.Apellido.Text = afiliado.apellido;
                this.Id.Text = afiliado.id.ToString();
                this.dataGridView1.DataSource = RolManager.obtenerRolesDeUsuario(afiliado.id);
                this.dataGridView2.DataSource = RolManager.obtenerRolesFaltantesUsuario(afiliado.id);
            }
        }

        private void AltaRolPorUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un rol para agregar");
            }
            else{
                DataGridViewSelectedRowCollection seleccion = this.dataGridView2.SelectedRows;
                foreach (DataGridViewRow rol in seleccion)
                {
                   RolManager.agregarRolesAUsuario(afiliado.id, Convert.ToInt32(rol.Cells[0].Value));
                }

                MessageBox.Show("Los roles han sido agregados al usuario exitosamente");
                this.dataGridView1.DataSource = RolManager.obtenerRolesDeUsuario(afiliado.id);
                this.dataGridView2.DataSource = RolManager.obtenerRolesFaltantesUsuario(afiliado.id);
            
            }
        }
    }
}
