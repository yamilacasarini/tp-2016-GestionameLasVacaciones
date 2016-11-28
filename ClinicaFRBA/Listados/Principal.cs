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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            cargarSemestres();
        }
        private void cargarSemestres()
        {
            DateTime fechaInicio = new DateTime(2015, 01, 01);
            DateTime fechaFin = DateTime.Now;
            DateTime fechaPaso = fechaInicio;
            while (!(fechaPaso.Year > fechaFin.Year))
            {
                comboBox1.Items.Add(fechaPaso);
                fechaPaso =fechaPaso.AddMonths(6);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No ingreso un periodo");
            }
            else
            {
                new EspecialidadesCancelaciones(Convert.ToDateTime(comboBox1.SelectedItem)).Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No ingreso un periodo");
            }
            else
            {
                new ProfesionalesConMasConsultas(Convert.ToDateTime(comboBox1.SelectedItem)).Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No ingreso un periodo");
            }
            else
            {
                new ProfesionalesConMenosHoras(Convert.ToDateTime(comboBox1.SelectedItem)).Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No ingreso un periodo");
            }
            else
            {
                new AfiliadoConMayorCantidadDeBonos(Convert.ToDateTime(comboBox1.SelectedItem)).Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No ingreso un periodo");
            }
            else
            {
                new EspecialidadesConMasConsultas(Convert.ToDateTime(comboBox1.SelectedItem)).Show();
            }
        }
    }
}