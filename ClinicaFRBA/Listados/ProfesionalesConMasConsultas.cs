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
            InitializeComponent();
            ListadosManager.obtenerLaListaDePlanes().ForEach(cargarEnCombobox);
        }
        private void cargarEnCombobox(Plan plan)
        {

            comboBox1.Items.Add(plan.descripcion);


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                     Plan planSeleccionaddo =ListadosManager.obtenerLaListaDePlanes().Find((x => x.descripcion == comboBox1.SelectedItem.ToString()));
                     dataGridView1.DataSource = ListadosManager.ObtenerProfesionalesMasConsultados(planSeleccionaddo.id,fecha,fecha.AddMonths(6)).ToList();
                     }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
            }
        }
    }
}
