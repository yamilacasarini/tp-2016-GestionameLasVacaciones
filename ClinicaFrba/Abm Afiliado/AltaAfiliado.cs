using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AltaAfiliado : Form
    {
        Afiliado afiliadoFamiliar = new Afiliado();
        public static Server server;
        private SqlDataReader reader;


        public AltaAfiliado()
        {
            InitializeComponent();
            llenarPlanes();
            btAgregarFam.Hide();
            labelFamiliar.Hide();
            if (afiliadoFamiliar.id != 0)
            {
                labelFamiliar.Text = "Ingresando familiar de:" + afiliadoFamiliar.apellido;
                labelFamiliar.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void llenarPlanes()
        {
            server = Server.getInstance();
            reader = server.query("SELECT DISTINCT descripcion FROM GESTIONAME_LAS_VACACIONES.Planes");

            while (reader.Read())
            {
                cBplanMedico.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                server.query("EXEC GESTIONAME_LAS_VACACIONES.altaPaciente '" +
                txNombre.Text.Trim() + "', '" + txApellido.Text.Trim() + "'," + txDocumento.Text.Trim() + ",'" + txDireccion.Text.Trim() + "'," + txTelefono.Text.Trim() +
                ",'" + txMail.Text.Trim() + "','" + Convert.ToDateTime(dateTimePicker1.Value) + "','" + cBsexo.Text.Trim() + "','" + cBestadoCivil.Text.Trim() + "'," + txFamiliaresACargo.Text.Trim() +
                ", "+ AfiliadoManager.idPlanMedico(cBplanMedico.Text.Trim()));
                btAgregar.Hide();
                if (cBplanMedico.Text.Trim() == "Soltero" || cBplanMedico.Text.Trim() == "Concubinato" || Convert.ToInt32(txFamiliaresACargo.Text.Trim()) > 0)
                {
                 //   btAgregarFam.Show();
                  //  afiliadoFamiliar.nombre = txNombre.Text.Trim();
                  //  afiliadoFamiliar.apellido = txApellido.Text.Trim();
                  //  afiliadoFamiliar.id = AfiliadoManager.id(txDocumento.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txDireccion_TextChanged(object sender, EventArgs e)
        {

        }
        bool validarDatos()
        {
            return txNombre.Text.Trim() != "" && txApellido.Text.Trim() != "" &&
                txTelefono.Text.Trim() != "" && txMail.Text.Trim() != "" &&
                txDireccion.Text.Trim() != "" && txDocumento.Text.Trim() != "" &&
                cBestadoCivil.Text.Trim() != "" && cBplanMedico.Text.Trim() != "" &&
                cBsexo.Text.Trim() != "" && cBtipoDocumento.Text.Trim() != "";
        }

        private void cBtipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void txMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cBsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txFamiliaresACargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btAgregarFam_Click(object sender, EventArgs e)
        {
            AltaAfiliado form = new AltaAfiliado();
            form.afiliadoFamiliar = afiliadoFamiliar;
            form.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}