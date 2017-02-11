using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class Principal : Form
    {
        buscarTurno buscador;
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Sesion.getInstance().rol == "Profesional")
                buscador = new buscarTurno(Sesion.getInstance().profesional.matricula);
            else
                buscador = new buscarTurno(-1);
            buscador.ShowDialog();
            if (buscador.turnoSelect != null)
            {
                textBox2.Text = buscador.turnoSelect.id.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") {
                MessageBox.Show("No ha ingresado el numero de turno aun");
                return; 
            }
            TurnosManager.PersistirCambios(buscador.turnoSelect);
            MessageBox.Show("Se registro la llegada del turno exitosamente!");
        }
    }
}
