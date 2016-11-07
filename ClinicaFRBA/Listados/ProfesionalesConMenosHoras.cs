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
    public partial class ProfesionalesConMenosHoras : Form
    {
        public ProfesionalesConMenosHoras(DateTime dia)
        {
            InitializeComponent();
            try
            {
                Server server = Server.getInstance();
                SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.topprofesionalesConMasHoras()");
                List<ProfesionalesPorConsulta> prof = new List<ProfesionalesPorConsulta>();
                while (reader.Read())
                {
                    ProfesionalesPorConsulta profesional = new ProfesionalesPorConsulta();
                    profesional.idProfesional = Convert.ToInt32(reader["idProfesional"]);
                    profesional.cantidadDeConsultas = Convert.ToInt32(reader["cantidadDeHoras"]);
                    prof.Add(profesional);
                }
                reader.Close();
                dataGridView1.DataSource = prof;
            }catch(Exception ex)
            {
            MessageBox.Show(ex.Message);}
        }
    }
}
