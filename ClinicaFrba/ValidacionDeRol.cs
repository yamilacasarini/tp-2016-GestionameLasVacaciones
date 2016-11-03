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
        Server server=Server.getInstance();
        public ValidacionDeRol(String id)
        {
            InitializeComponent();
            rellenarListaConRoles(id);
            
        }

        public void rellenarListaConRoles(String id)
        {server=Server.getInstance();
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.RolesxUsuario u JOIN GESTIONAME_LAS_VACACIONES.Roles r ON u.idRol = r.id WHERE u.idUsuario = " + "'" + id.ToString() + "'");
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
            if (FuncionalidadComboBox.SelectedItem != "")
            {
            //    Sesion.getInstance.rol = FuncionalidadComboBox.Text.Trim();
                this.Close();
                switch (FuncionalidadComboBox.Text.ToString())
                {
                    case "ABM ROL":
                        new AbmRol.Principal().ShowDialog();
                        break;
                    case "ABM AFILIADOS":
                        new Abm_Afiliado.Principal().ShowDialog();
                        break;
                    case "COMPRA BONOS":
                        new Compra_Bono.Principal().ShowDialog();
                        break;
                    case "PEDIDO DE TURNO":
                        new Pedir_Turno.PrincipalProf().ShowDialog();
                        break;
                    case "REGISTRO DE LLEGADA":
                        new Registro_Llegada.Principal().ShowDialog();
                        break;
                    case "CANCELAR TURNO":
                        new Cancelar_Atencion.Principal().ShowDialog();
                        break;
                    case "LISTADO ESTADISTICO":
                        new Listados.Principal().ShowDialog();
                        break;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataReader reader = server.query("select f.descripcion from GESTIONAME_LAS_VACACIONES.Funcionalidades f  join GESTIONAME_LAS_VACACIONES.RolesxFuncionalidad r on f.id = r.idFuncionalidad  join GESTIONAME_LAS_VACACIONES.Roles rol on r.idRol = rol.id where rol.descripcion= " + "'" + RolComboBox.SelectedItem.ToString() + "'");
            while (reader.Read())
            {
                FuncionalidadComboBox.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();

        }
    }
}
