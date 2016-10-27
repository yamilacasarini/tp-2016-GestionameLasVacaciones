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
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.RolxUsuario u JOIN GESTIONAME_LAS_VACACIONES.Rol r ON u.idRol = r.id WHERE u.idUsuario =" + "'" + id + "'");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select descripcion from GESTIONAME_LAS_VACACIONES.Funcionalidad f  join GESTIONAME_LAS_VACACIONES.RolxFuncionalidad r on f.id = r.idFuncionalidad where r.idRol = 1");
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();

        }
    }
}
