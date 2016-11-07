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
        public ProfesionalesMasConsultados()
        {
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
    }
}
