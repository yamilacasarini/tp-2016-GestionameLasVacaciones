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
        List<Plan> planes = new List<Plan>();
        List<ProfesionalesPorConsulta> especialidades = new List<ProfesionalesPorConsulta>();
        DateTime diaSeleccionado;
        public ProfesionalesMasConsultados(DateTime dia)
        {
            diaSeleccionado = dia;
            InitializeComponent();
            llenarPlanes();
        }
        private void llenarPlanes()
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT id, descripcion FROM GESTIONAME_LAS_VACACIONES.Planes");
            
            while (reader.Read())
            {
                Plan plan = new Plan();
                plan.descripcion = reader["descripcion"].ToString();
                plan.id = Convert.ToInt32(reader["id"]);
                planes.Add(plan);
            }
            reader.Close();
            planes.ForEach(agregarAlCombobox);
        }
        private void agregarAlCombobox(Plan plan) {
            comboBox1.Items.Add(plan.descripcion.ToString());
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No ha seleccionado ningun plan");
            }
            else
            {
                try
                {
                    Plan planSeleccionaddo = planes.Find((x => x.descripcion == comboBox1.SelectedItem.ToString()));
                   
                    dataGridView1.DataSource = ListadosManager.ObtenerProfesionalesMasConsultados(planSeleccionaddo.id,diaSeleccionado,diaSeleccionado.AddMonths(6)).ToList();
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
