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
    public partial class BuscarModificaciones : Form
    {
        public BuscarModificaciones()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txApellido.Text.Trim() != "" || txId.Text.Trim() != "" || txNombre.Text.Trim() != "" || txPlan.Text.Trim() != "")
            {
                if (!(Validacion.soloNumeros(txId, "idPaciente") || Validacion.soloNumeros(txPlan, "idPlan")))
                    MessageBox.Show("Solo pueden ingresar numeros en los id");
                if (txId.Text.Trim() == "")
                    txId.Text = "-1";
                if (txPlan.Text.Trim() == "")
                    txPlan.Text = "-1";

                try
                {
                    this.dataGridView1.DataSource = AfiliadoManager.BuscarModificaciones(txNombre.Text.Trim(), txApellido.Text.Trim(), Convert.ToInt32(txId.Text.Trim()), Convert.ToInt32(txPlan.Text.Trim()));
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException fx) {
                    MessageBox.Show(fx.Message);
                }
            }
            else
                MessageBox.Show("Ingrese algun valor");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
