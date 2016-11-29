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
        DateTime fecha;
        public ProfesionalesConMenosHoras(DateTime dia)
        {
            
            InitializeComponent();
            fecha = dia;
            ListadosManager.obtenerLaListaDePlanes().ForEach(agregarAlCombobox);
            ListadosManager.obtenerEspecialidadesMedicas().ForEach(agregarAlComboboxDeEspecialidades);
        }
        private void agregarAlCombobox(Plan plan) {

            cbPlan.Items.Add(plan.descripcion);
        }
        private void agregarAlComboboxDeEspecialidades(Especialidad esp)
        {

            cbEspecialidad.Items.Add(esp.descripcion);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListadosManager.obtenerProfesionalesConMenosHoras(cbPlan.Text,cbEspecialidad.Text,fecha,fecha.AddMonths(6));

        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

    }
}
