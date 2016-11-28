using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ProfesionalesConMasConsultas : Form
    {
        DateTime fecha; 
        public ProfesionalesConMasConsultas(DateTime fechaInicio)
        {
            fecha = fechaInicio;
            ListadosManager.obtenerLaListaDePlanes().ForEach(cargarEnCombobox);
            InitializeComponent();
         }
        private void cargarEnCombobox(Plan plan)
        {

            comboBox1.Items.Add(plan.descripcion);
        
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
