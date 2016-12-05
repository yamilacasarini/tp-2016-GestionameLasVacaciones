using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionMedico : Form
    {
        public int matricula;
        public String especialidadMedico;
        public CancelacionMedico(int id, String especialidad, List<Agenda> agenda)
        {
            especialidadMedico = especialidad;
            matricula = id;
            InitializeComponent();
            this.dataAgenda.DataSource = agenda;
            
        }

        private void CancelacionMedico_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtDia.MaskCompleted)
            {
                MessageBox.Show("Por favor, ingrese un día a cancelar");
                return;
            }
            if (String.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe especificar un motivo");
                return;
            }
            try
            {
                CancelacionManager.cancelarDiaProfesional(matricula, Convert.ToDateTime(txtDia.Text.Trim()), txtMotivo.Text.Trim(), especialidadMedico);
            }
            catch (Exception b)
            {
                MessageBox.Show("El dia no se encuentra agendado");
                return;
           }
            MessageBox.Show("Dia cancelado correctamente");
            this.dataAgenda.DataSource = CancelacionManager.mostrarAgendaProfesional(matricula);


        }

        private void dataAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe especificar un motivo");
                return;
            }
            if (!txtDesde.MaskCompleted || !txtHasta.MaskCompleted)
            {
                MessageBox.Show("Ingrese ambas fechas del período");
                return;
            }
            if (DateTime.Compare(Convert.ToDateTime(txtDesde.Text), Convert.ToDateTime(txtHasta.Text)) > 0)
            {
                MessageBox.Show("La fecha inicio del periodo es mayor a la final");
                txtDesde.Clear();
                txtHasta.Clear();
                return;
            }
            try
            {
                CancelacionManager.cancelarPeriodoProfesional(matricula, Convert.ToDateTime(txtDesde.Text.Trim()), Convert.ToDateTime(txtHasta.Text.Trim()), txtMotivo.Text.Trim(), especialidadMedico);
            }
            catch (Exception b)
            {
                MessageBox.Show("El rango de fechas no se encuentra agendado");
                return;
            }
            MessageBox.Show("Periodo cancelado correctamente");
            this.dataAgenda.DataSource = CancelacionManager.mostrarAgendaProfesional(matricula);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
