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
        Profesional profesional = null;
        DateTime fechaElegida;

        public ListarTurnos(Profesional prof)
        {
            matr = prof.matricula;
            esp = prof.especialidad;
            profesional = prof;
            InitializeComponent();
            this.dataGridView1.DataSource = ProfesionalManager.MostrarTurnosDeProfesional(matr, esp);
            dataGridView1.Columns["Ticks"].Visible = false;
            dataGridView1.Columns["Year"].Visible = false;
            dataGridView1.Columns["Month"].Visible = false;
            dataGridView1.Columns["Day"].Visible = false;
            dataGridView1.Columns["Second"].Visible = false;
            dataGridView1.Columns["Millisecond"].Visible = false;
            dataGridView1.Columns["DayOfWeek"].Visible = false;
            dataGridView1.Columns["DayOfYear"].Visible = false;
            dataGridView1.Columns["Kind"].Visible = false;
            dataGridView1.Columns["Minute"].Visible = false;
            dataGridView1.Columns["Hour"].Visible = false;

        }

        private void ListarTurnos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                fechaElegida = new DateTime(Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value), 0);
                
                Abm_Afiliado.BuscarAfiliados buscador = new Abm_Afiliado.BuscarAfiliados();
                buscador.ShowDialog();
                Abm_Afiliado.Afiliado afiliado = buscador.afiliadoBuscado;
                int afiliadoID = afiliado.id;
          
                Confirmacion conf = new Confirmacion(fechaElegida, afiliado, profesional);
                conf.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
