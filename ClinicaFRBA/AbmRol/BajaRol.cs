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
    public partial class BajaRol : Form
    {

        public BajaRol()
        {
            InitializeComponent();
            rellenarListaConRoles(Convert.ToString(login.usuario));
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (RolManager.obtenerBaja(comboEliminar.Text.Trim()) == 1)
            {
                MessageBox.Show("El Rol ya fue anteriormente dado de baja");
            }
            else
            {
                RolManager.deshabilitarRol(comboEliminar.Text.Trim());
                MessageBox.Show("El rol fue eliminado");
               
            }
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BajaRol_Load(object sender, EventArgs e)
        {

        }
        public void rellenarListaConRoles(String id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.RolesxUsuario u JOIN GESTIONAME_LAS_VACACIONES.Roles r ON u.idRol = r.id WHERE u.idUsuario = " + "'" + id.ToString() + "'");
            while (reader.Read())
            {
                comboEliminar.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
