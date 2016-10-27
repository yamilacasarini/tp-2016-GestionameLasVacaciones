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
        Server server;
        public ValidacionDeRol(String id)
        {
            InitializeComponent();
            rellenarListaConRoles(id);
            server=Server.getInstance();
        }

        public void rellenarListaConRoles(String id)
        {
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.RolxUsuario u JOIN GESTIONAME_LAS_VACACIONES.Rol r ON u.idRol = r.id WHERE u.idUsuario =" + "'" + id + "'");
            while (reader.Read())
            {
                RolComboBox.Items.Add(reader["descripcion"].ToString());
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

            this.Hide();
            switch (FuncionalidadComboBox.Text.ToString())
            {
                case "ABM ROL":
                    new AbmRol.Principal().Show();
                    break;
                case "ABM AFILIADOS":
                    new Abm_Afiliado.Principal().Show();
                    break;
                case "COMPRA BONOS":
                    new Compra_Bono.Principal().Show();
                    break;
                case "PEDIDO DE TURNO":
                    new Pedir_Turno.Principal().Show();
                    break;
                case "REGISTRO DE LLEGADA":
                    new Registro_Llegada.Principal().Show();
                    break;
                case "CANCELAR TURNO":
                    new Cancelar_Atencion.Principal().Show();
                    break;
                case "LISTADO ESTADISTICO":
                    new Listados.Principal().Show();
                    break;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataReader reader = server.query("select descripcion from GESTIONAME_LAS_VACACIONES.Funcionalidad f  join GESTIONAME_LAS_VACACIONES.RolxFuncionalidad r on f.id = r.idFuncionalidad where r.idRol = 1");
            while (reader.Read())
            {
                FuncionalidadComboBox.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();

        }
    }
}
