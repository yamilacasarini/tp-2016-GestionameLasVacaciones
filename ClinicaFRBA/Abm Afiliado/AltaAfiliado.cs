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
        public Afiliado afiliadoFamiliar = new Afiliado();

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void llenarPlanes()
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT DISTINCT descripcion FROM GESTIONAME_LAS_VACACIONES.Planes");

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
                try
                {
                    AfiliadoManager.altaAfiliado(txNombre.Text.Trim(), txApellido.Text.Trim(),
                        Convert.ToInt32(txDocumento.Text.Trim()), txDireccion.Text.Trim(), Convert.ToInt32(txTelefono.Text.Trim()),
                        txMail.Text.Trim(), Convert.ToDateTime(dateTimePicker1.Value), cBsexo.Text.Trim(),
                        cBestadoCivil.Text.Trim(), Convert.ToInt32(txFamiliaresACargo.Text.Trim()), cBplanMedico.Text.Trim());
                    btAgregar.Hide();
                    if (cBplanMedico.Text.Trim() == "Soltero" || cBplanMedico.Text.Trim() == "Concubinato" || Convert.ToInt32(txFamiliaresACargo.Text.Trim()) > 0)
                    {
                        btAgregarFam.Show();
                        afiliadoFamiliar.nombre = txNombre.Text.Trim();
                        afiliadoFamiliar.apellido = txApellido.Text.Trim();
                        afiliadoFamiliar.id = AfiliadoManager.id(txDocumento.Text.Trim());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Datos inconsistentes");
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
                cBsexo.Text.Trim() != "" && cBtipoDocumento.Text.Trim() != "" &&
            Validacion.soloLetras(txNombre, "nombre") && Validacion.soloLetras(txApellido, "apellido") &&
            Validacion.soloNumeros(txTelefono, "telefono") && Validacion.emailValido(txMail) &&
            Validacion.esAlfanumerico(txDireccion, "direccion") && Validacion.soloNumeros(txDocumento, "documento") &&
            Validacion.soloNumeros(txFamiliaresACargo, "familiares") && Convert.ToInt32(txFamiliaresACargo.Text.Trim()) >= 0;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cBsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txFamiliaresACargo_TextChanged(object sender, EventArgs e)
        {

        }


        private void txTelefono_TextChanged(object sender, EventArgs e)
        {

        }


        private void btAgregarFam_Click(object sender, EventArgs e)
        {
            AltaAfiliado form = new AltaAfiliado();
            form.afiliadoFamiliar = afiliadoFamiliar;
            form.ShowDialog();
        }

    }
}