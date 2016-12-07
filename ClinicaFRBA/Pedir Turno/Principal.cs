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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Profesional profesionalSeleccionado = new Profesional();
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                ListarTurnos listado = new ListarTurnos(profesionalSeleccionado);
                listado.ShowDialog();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                //System.Windows.Forms.MessageBox.Show("El profesional no tiene ninguna agenda cargada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarProfesional buscador = new BuscarProfesional();
                buscador.ShowDialog();
                profesionalSeleccionado = buscador.profesional;
                label2.Text = (profesionalSeleccionado.apellido + "," + profesionalSeleccionado.nombre + ". Matricula: " + profesionalSeleccionado.matricula);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception eg)
            {
                MessageBox.Show(eg.Message);
            }
        }
    }
}
