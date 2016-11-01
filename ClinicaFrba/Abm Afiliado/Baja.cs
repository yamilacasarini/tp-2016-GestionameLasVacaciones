using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                AfiliadoManager.borrarAfiliado(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Se ah dando de baja al afiliado");
            }
            else
            {
                MessageBox.Show("Seleccione una unica fila");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (txId.Text.Trim() == "") { txId.Text = "-1"; }

                this.dataGridView1.DataSource = AfiliadoManager.BuscarAfiliados(txNombre.Text.Trim(), txApellido.Text.Trim(), Convert.ToInt32(txId.Text.Trim()));
            }
            else
            {
                MessageBox.Show("Ingrese al menos un id");
            }
        }
        bool validarDatos()
        {
            return txApellido.Text.Trim() != "" || txNombre.Text.Trim() != "" || txId.Text.Trim() != "";
        }
    }
}
