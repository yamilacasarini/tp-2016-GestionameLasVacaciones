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
        public List<Agenda> agenda;
        public CancelacionMedico(int id, String especialidad)
        {
            InitializeComponent();
            especialidadMedico = especialidad;
            matricula = id;
            agenda = CancelacionManager.mostrarAgendaProfesional(matricula);//, especialidadMedico);
            if (agenda == null)
            {
                MessageBox.Show("El profesional no tiene turnos recientes");
                btnDia.Hide();
                btnPeriodo.Hide();
                label6.Hide();
                txtDesde.Enabled = false;
                txtDia.Enabled = false;
                txtHasta.Enabled = false;
                txtMotivo.Enabled = false;
            }
            else
            {


                this.dataAgenda.DataSource = agenda;
            }
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
                if (dataAgenda.SelectedRows.Count != 1){
                    MessageBox.Show("Por favor seleccione la agenda de la especialidad asociada a la cancelacion");
                    return;
                
                }
            if (String.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Debe especificar un motivo");
                return;
            
            }
            DateTime horaDelSistema = DateTime.ParseExact(Program.horarioSistema, "yyyy-dd-MM HH:mm:ss.fff",
                                     System.Globalization.CultureInfo.InvariantCulture);
            try
            {
                 Convert.ToDateTime(txtDia.Text.Trim());
            }
            catch (Exception a)
            {
                MessageBox.Show("Error, ha ingresado una fecha invalida");
                return;
            }
            if (horaDelSistema.CompareTo(Convert.ToDateTime(txtDia.Text.Trim())) > 0)
            {
                MessageBox.Show("La fecha inicio del periodo es mayor al dia del sistema");
                txtDesde.Clear();
                txtHasta.Clear();
                return;

            }
            if (horaDelSistema.CompareTo(Convert.ToDateTime(txtDia.Text.Trim()))== 0)
            {
                MessageBox.Show("La cancelacion debe ser con 24 hs de antelación");
                txtDesde.Clear();
                txtHasta.Clear();
                return;

            }
            try
            {



                especialidadMedico = dataAgenda.CurrentRow.Cells["especialidad"].Value.ToString();
                DateTime variableLoca = DateTime.Now;
               
                    variableLoca = Convert.ToDateTime(txtDia.Text.Trim());
                            
             
                    CancelacionManager.cancelarDiaProfesional(matricula, variableLoca, txtMotivo.Text.Trim(), especialidadMedico);
            }
            catch (Exception b)
            {
                MessageBox.Show(b.StackTrace);
                return;
           }
            MessageBox.Show("Dia cancelado correctamente");
            this.dataAgenda.DataSource = CancelacionManager.mostrarAgendaProfesional(matricula);//, especialidadMedico);


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
            if (dataAgenda.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor seleccione la agenda de la especialidad asociada a la cancelacion");
                return;

            }
            try
            {
                Convert.ToDateTime(txtDesde.Text.Trim());
                 Convert.ToDateTime(txtHasta.Text.Trim());
            }
            catch (Exception z)
            {
                MessageBox.Show("Las fechas insertadas son invalidas");
                return;
            }
           if (DateTime.Compare(Convert.ToDateTime(txtDesde.Text), Convert.ToDateTime(txtHasta.Text)) > 0)
            {
                MessageBox.Show("La fecha inicio del periodo es mayor a la final");
                txtDesde.Clear();
                txtHasta.Clear();
                return;
            }
    DateTime horaDelSistema = DateTime.ParseExact(Program.horarioSistema, "yyyy-dd-MM HH:mm:ss.fff",
                                     System.Globalization.CultureInfo.InvariantCulture);

    if (horaDelSistema.CompareTo(Convert.ToDateTime(txtDesde.Text.Trim())) > 0)
    {
        MessageBox.Show("La fecha inicio del periodo es mayor al dia del sistema");
        txtDesde.Clear();
        txtHasta.Clear();
        return;
        
    }
    if (horaDelSistema.CompareTo(Convert.ToDateTime(txtDesde.Text.Trim())) == 0)
    {
        MessageBox.Show("La cancelación debe ser con 24 hs de antelacion");
        txtDesde.Clear();
        txtHasta.Clear();
        return;

    }
            try
            {
                
                 DateTime fechaInicio = DateTime.Now;
                DateTime fechaFinal = DateTime.Now;
               
                    fechaInicio = Convert.ToDateTime(txtDesde.Text.Trim());
                    fechaFinal = Convert.ToDateTime(txtHasta.Text.Trim());
               
            
                especialidadMedico = dataAgenda.CurrentRow.Cells["especialidad"].Value.ToString();
                CancelacionManager.cancelarPeriodoProfesional(matricula, fechaInicio, fechaFinal, txtMotivo.Text.Trim(), especialidadMedico);
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
                return;
            }
            MessageBox.Show("Periodo cancelado correctamente");
            this.dataAgenda.DataSource = CancelacionManager.mostrarAgendaProfesional(matricula);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
