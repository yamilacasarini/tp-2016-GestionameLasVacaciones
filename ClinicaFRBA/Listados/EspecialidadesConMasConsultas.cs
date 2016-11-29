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
    public partial class EspecialidadesConMasConsultas : Form
    {
        public EspecialidadesConMasConsultas(DateTime fecha)
        {
            try
            {
                InitializeComponent();
                Server server = Server.getInstance();
                SqlDataReader reader = server.query("select  id, cantidadDeConsultas, especialidad from GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas('" + fecha.ToString() + "','" + fecha.AddMonths(6).ToString() + "')");
                List<Especialidad> especialidades = new List<Especialidad>();
                while (reader.Read())
                {
                    Especialidad unaEspecialidad = new Especialidad();
                    unaEspecialidad.id = Convert.ToInt32(reader["id"]);
                    unaEspecialidad.cantidadConsultas = Convert.ToInt32(reader["cantidadDeConsultas"]);
                    unaEspecialidad.descripcion = reader["especialidad"].ToString();
                    especialidades.Add(unaEspecialidad);
                }
                reader.Close();
                MessageBox.Show("La cantidad de especialidades son " + especialidades.Count());
                dataGridView1.DataSource = especialidades;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
