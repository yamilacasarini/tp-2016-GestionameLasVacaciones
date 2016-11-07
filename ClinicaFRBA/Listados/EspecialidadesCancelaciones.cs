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
    public partial class EspecialidadesCancelaciones : Form
    {
        public EspecialidadesCancelaciones(DateTime fecha)
        {
            InitializeComponent();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  * from GESTIONAME_LAS_VACACIONES.top5EspecialidadesConMasCancelaciones('"+fecha.ToString()+"','"+fecha.AddMonths(6).ToString()+"')");
            List<String> especialidades = new List<String>();
            while (reader.Read())
            {
                String nombreDeEspecialidad = reader["descripcion"].ToString();
                especialidades.Add(nombreDeEspecialidad);
            }
            reader.Close();
            dataGridView1.DataSource = especialidades;
        }
    }
}
