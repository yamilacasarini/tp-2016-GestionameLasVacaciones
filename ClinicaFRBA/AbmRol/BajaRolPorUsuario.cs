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
namespace ClinicaFrba.AbmRol
{
    public partial class BajaRolPorUsuario : Form
    {
        public Abm_Afiliado.Afiliado afiliado;
        public BajaRolPorUsuario(Abm_Afiliado.Afiliado unAfiliado)
        {
            afiliado = unAfiliado;
            InitializeComponent();
            this.Nombre.Text = afiliado.nombre;
            this.Apellido.Text = afiliado.apellido;
            this.Id.Text = afiliado.id.ToString();
            rellenarConRolesDeAfiliado(afiliado);
            

            

        }
        private void rellenarConRolesDeAfiliado(Abm_Afiliado.Afiliado unAfiliado)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Roles r JOIN GESTIONAME_LAS_VACACIONES.RolesxUsuario rxu ON r.id = rxu.idRol JOIN GESTIONAME_LAS_VACACIONES.Pacientes pa ON rxu.idUsuario = pa.usuario WHERE pa.id= '" + unAfiliado.id + "'");
            while (reader.Read())
            {
                roles.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        
        }
        private void BajaRolPorUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            if (roles.SelectedItem != null)
            {
                try
                {
                    RolManager.eliminarRolPorUsuario(afiliado.id, roles.Text.Trim());
                }
                catch (Exception a)
                {
                    MessageBox.Show("No se pudo borrar el Rol del paciente");
                    return;
                }
                MessageBox.Show("El rol fue eliminado con exito");
                roles.Items.Clear();
                rellenarConRolesDeAfiliado(afiliado);
            }
            else
            {
                MessageBox.Show("No hay ningun rol seleccionado");
            }
        }
    }
}
