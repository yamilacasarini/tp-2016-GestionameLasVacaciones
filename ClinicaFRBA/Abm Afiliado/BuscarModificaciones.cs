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
            SqlDataReader reader = server.query("select descripcion from GESTIONAME_LAS_VACACIONES.Planes");
            List<String> idsPlanes = new List<string>();
            idsPlanes.Add("");
            while (reader.Read()) { 

            idsPlanes.Add(reader["descripcion"].ToString());
            
            }

            reader.Read();
            cbIdPlan.DataSource = idsPlanes;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txApellido.Text.Trim() != "" || txId.Text.Trim() != "" || txNombre.Text.Trim() != "" || cbIdPlan.SelectedItem.ToString().Trim() != "")
            {
                String plan;
                String idPaciente = txId.Text.Trim();
                if (!(Validacion.soloNumeros(txId, "idPaciente")))
                    MessageBox.Show("Solo pueden ingresar numeros en los id");
                if (idPaciente == "")
                    idPaciente = "-1";
                if (cbIdPlan.SelectedItem.ToString().Trim() == "")
                    plan = "''";
                else
                    plan = cbIdPlan.SelectedItem.ToString().Trim();

                try
                {
                    dataGridView1.DataSource = AfiliadoManager.BuscarModificaciones(txNombre.Text.Trim(), txApellido.Text.Trim(), Convert.ToInt32(idPaciente), plan);
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
