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
            Server server= Server.getInstance();
            SqlDataReader reader = server.query("select id from GESTIONAME_LAS_VACACIONES.Planes");
            List<String> idsPlanes = new List<string>();
            idsPlanes.Add("");
            while (reader.Read()) { 

            idsPlanes.Add(reader["id"].ToString());
            
            }

            reader.Read();
            comboBox1.DataSource = idsPlanes;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txApellido.Text.Trim() != "" || txId.Text.Trim() != "" || txNombre.Text.Trim() != "" || comboBox1.SelectedItem.ToString().Trim() != "")
            {
                String aux;
                if (!(Validacion.soloNumeros(txId, "idPaciente")))
                    MessageBox.Show("Solo pueden ingresar numeros en los id");
                if (txId.Text.Trim() == "")
                    txId.Text = "-1";
                if (comboBox1.SelectedItem.ToString().Trim() == "")
                    aux = "-1";
                else
                    aux = comboBox1.SelectedItem.ToString().Trim();

                try
                {
                    dataGridView1.DataSource = AfiliadoManager.BuscarModificaciones(txNombre.Text.Trim(), txApellido.Text.Trim(), Convert.ToInt32(txId.Text.Trim()), Convert.ToInt32(aux));
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

        private void BuscarModificaciones_Load(object sender, EventArgs e)
        {

        }
    }

}
