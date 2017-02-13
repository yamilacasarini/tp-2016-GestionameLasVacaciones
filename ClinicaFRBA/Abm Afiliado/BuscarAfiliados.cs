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

namespace ClinicaFrba.Abm_Afiliado
{

    public partial class BuscarAfiliados : Form
    {
        public int abrirCancelacion = 0;
        public Afiliado afiliadoBuscado = new Afiliado();
        public modificarAfiliado formAnterior;
        public BuscarAfiliados()
        {
            InitializeComponent();
            afiliadoBuscado.id = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                afiliadoBuscado.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                afiliadoBuscado.nombre = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                afiliadoBuscado.apellido = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                afiliadoBuscado.documento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                afiliadoBuscado.tipoDocumento = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                 afiliadoBuscado.direccion = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                afiliadoBuscado.telefono= Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                afiliadoBuscado.email = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                afiliadoBuscado.fechaNacimiento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value);
                afiliadoBuscado.sexo = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                afiliadoBuscado.estadoCivil = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                afiliadoBuscado.cantFamiliares = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
               afiliadoBuscado.cantConsultas= Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                afiliadoBuscado.servicio = Convert.ToInt32(dataGridView1.CurrentRow.Cells[13].Value);
                if (abrirCancelacion == 1)
                {
                    if(AfiliadoManager.noTieneTurnosSinCancelar(afiliadoBuscado.id))
                    {
                        MessageBox.Show("El Afiliado no tiene turnos para cancelar");
                        return;
                    }
                    Cancelar_Atencion.CancelacionAfiliado cancelacion = new Cancelar_Atencion.CancelacionAfiliado(afiliadoBuscado.id);
                    cancelacion.ShowDialog();
                }
         
                this.Close();

            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            afiliadoBuscado.id = -1;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                try
                {
                    String auxID;
                    if (txId.Text.Trim() == "")
                        auxID = "-1";
                    else
                        auxID = txId.Text.Trim();
                    this.dataGridView1.DataSource = AfiliadoManager.BuscarAfiliados(txNombre.Text.Trim(), txApellido.Text.Trim(), Convert.ToInt32(auxID));
                    dataGridView1.Columns["servicio"].Visible = false;
                }
                catch (FormatException fx)
                {
                    MessageBox.Show(fx.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese al menos un id");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        bool validarDatos()
        {
            return (txApellido.Text.Trim() != "" || txNombre.Text.Trim() != "" || txId.Text.Trim() != "") &&
              Validacion.soloLetras(txApellido, "apellido") && Validacion.soloLetras(txNombre, "nombre") &&
              Validacion.soloNumeros(txId, "id");
        }

        private void BuscarAfiliados_Load(object sender, EventArgs e)
        {

        }

        private void txId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
