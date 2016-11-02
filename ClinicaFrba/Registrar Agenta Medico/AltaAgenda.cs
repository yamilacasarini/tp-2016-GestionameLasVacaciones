using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class AltaAgenda : Form
    {
        public AltaAgenda()
        {
            InitializeComponent();
            comboSemanaDesde.Items.Add("Lunes");
            comboSemanaDesde.Items.Add("Martes");
            comboSemanaDesde.Items.Add("Miercoles");
            comboSemanaDesde.Items.Add("Jueves");
            comboSemanaDesde.Items.Add("Viernes");
            comboSemanaDesde.Items.Add("Sabado");
            comboSemanaDesde.Items.Add("Domingo");
            comboSemanaHasta.Items.Add("Lunes");
            comboSemanaHasta.Items.Add("Martes");
            comboSemanaHasta.Items.Add("Miercoles");
            comboSemanaHasta.Items.Add("Jueves");
            comboSemanaHasta.Items.Add("Viernes");
            comboSemanaHasta.Items.Add("Sabado");
            comboSemanaHasta.Items.Add("Domingo");
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
