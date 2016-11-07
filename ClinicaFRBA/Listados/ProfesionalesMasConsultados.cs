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
namespace ClinicaFrba.Listados
{
    public partial class ProfesionalesMasConsultados : Form
    {
        DateTime diaSeleccionado;
        public ProfesionalesMasConsultados(DateTime dia)
        {
            diaSeleccionado = dia;
            InitializeComponent();
            llenarPlanes();
        }
        private void llenarPlanes() {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT DISTINCT descripcion FROM GESTIONAME_LAS_VACACIONES.Planes");

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  * from GESTIONAME_LAS_VACACIONES.getTop5Profesionales('" + diaSeleccionado.ToString() + "','" + diaSeleccionado.AddMonths(6).ToString() + "')");
            List<ProfesionalesPorConsulta> especialidades = new List<ProfesionalesPorConsulta>();
            while (reader.Read())
            {
                ProfesionalesPorConsulta prof = new ProfesionalesPorConsulta();
                prof.idProfesional = Convert.ToInt32(reader["idProf"]);
                prof.cantidadDeConsultas  = Convert.ToInt32(reader["cantConsultas"]);
                especialidades.Add(prof);
            }
            reader.Close();
            dataGridView1.DataSource = especialidades;
        }
        }
    }
