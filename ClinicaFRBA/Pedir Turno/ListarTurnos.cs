using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class ListarTurnos : Form
    {

        int matr;
        String esp; 
        public ListarTurnos(int matricula, String especialidad)
        {
            matr = matricula;
            esp = especialidad;
            InitializeComponent();
            

        }

        private void ListarTurnos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource =   ProfesionalManager.MostrarTurnosDeProfesional(matr, esp);
        }
    }
}
