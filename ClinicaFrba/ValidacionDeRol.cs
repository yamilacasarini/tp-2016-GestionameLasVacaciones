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

namespace ClinicaFrba
{
    public partial class ValidacionDeRol : Form
    {
        public ValidacionDeRol(String id)
        {
            InitializeComponent();
            rellenarListaConRoles(id);
        }

        public void rellenarListaConRoles(String id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.RolxUsuario u JOIN GESTIONAME_LAS_VACACIONES.Rol r ON u.idRol = r.id WHERE u.idUsuario like " + id);
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
