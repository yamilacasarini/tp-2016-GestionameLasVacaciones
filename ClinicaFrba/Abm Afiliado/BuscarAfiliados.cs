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
        public Afiliado afiliadoBuscado = new Afiliado();
        public BuscarAfiliados()
        {
            InitializeComponent();
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
                afiliadoBuscado.telefono= Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                afiliadoBuscado.email = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                afiliadoBuscado.fechaNacimiento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value);
                afiliadoBuscado.sexo = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                afiliadoBuscado.estadoCivil = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
                afiliadoBuscado.cantFamiliares = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
               afiliadoBuscado.cantConsultas= Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                afiliadoBuscado.servicio = Convert.ToInt32(dataGridView1.CurrentRow.Cells[13].Value);
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
                if (txId.Text.Trim() == "")
                    txId.Text = "-1";
                this.dataGridView1.DataSource = AfiliadoManager.BuscarAfiliados(txApellido.Text.Trim(), txNombre.Text.Trim(), Convert.ToInt32(txId.Text.Trim()));
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
            return txApellido.Text.Trim() != "" && txNombre.Text.Trim() != "" || txId.Text.Trim() != "";
        }
    }
}

