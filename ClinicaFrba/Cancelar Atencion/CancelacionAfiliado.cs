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
    public partial class CancelacionAfiliado : Form
    {
        public CancelacionAfiliado(int id)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CancelacionManager.mostrarTurnosAfiliado(id);
        }

        private void CancelacionAfiliado_Load(object sender, EventArgs e)
        {

        }
        public bool cancelarTurnoDelDiaCorriente(DateTime dia)
        {
            return (dia == DateTime.Today);
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMotivo.Text.Trim()))
            {
                MessageBox.Show("Por favor, indique el motivo de la cancelacion");
                return;
            }
            switch (this.dataGridView1.SelectedRows.Count)
            {
                case 0:
                MessageBox.Show("Seleccione un turno a cancelar");
                break;
                case 1:
                if (cancelarTurnoDelDiaCorriente(Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value)))
                    MessageBox.Show("Error, no puede cancelar un turno de hoy");
                else
                {
                    try
                    {
                        CancelacionManager.cancelarTurno(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value),
                            Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value),
                            Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value), txtMotivo.Text.Trim());
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("La cancelacion no pudo realizarse");
                        return;
                    }

                    MessageBox.Show("El turno fue cancelado");
                    this.dataGridView1.DataSource = CancelacionManager.mostrarTurnosAfiliado(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value));


                }
                    break;
                default:
                    MessageBox.Show("Seleccione de a un turno");
                    break;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
