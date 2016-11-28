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
            ListadosManager.obtenerLaListaDePlanes().ForEach(agregarAlCombobox);
        }
        private void agregarAlCombobox(Plan plan) {

            comboBox1.Items.Add(plan.descripcion);
        }

    }
}
