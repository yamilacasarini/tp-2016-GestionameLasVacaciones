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
            List<Especialidad> especialidades = ListadosManager.ObtenerProfesionalesConMasBonos(fecha);
            try
            {
                InitializeComponent();
               //  MessageBox.Show("La cantidad de especialidades son " + especialidades.Count());
              
            dataGridView1.DataSource = especialidades;
          
           }
           catch (Exception ex) {
                MessageBox.Show(ex.Message);
           }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
