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
            dateTimePicker1.Value = DateTime.ParseExact(Program.horarioSistema.ToString(),"yyyy-dd-MM HH:mm:ss.fff",null);
            btAgregarFam.Hide();
            labelFamiliar.Hide();
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
            if (dateTimePicker1.Value.CompareTo(DateTime.ParseExact(Program.horarioSistema.ToString(), "yyyy-dd-MM HH:mm:ss.fff", null)) > 0) {
                MessageBox.Show("El paciente aun no nacio");
                return;
            }


            if (validarDatos())
            {
                try
                {
                    AfiliadoManager.altaAfiliado(txNombre.Text.Trim(), txApellido.Text.Trim(),
                        Convert.ToInt32(txDocumento.Text.Trim()), txDireccion.Text.Trim(), txTelefono.Text.Trim(),
                        txMail.Text.Trim(), Convert.ToDateTime(dateTimePicker1.Value), cBsexo.Text.Trim(),
                        cBestadoCivil.Text.Trim(), Convert.ToInt32(txFamiliaresACargo.Text.Trim()), cBplanMedico.Text.Trim(), this.afiliadoFamiliar.id, cBtipoDocumento.Text.Trim());
                    btAgregar.Hide();
                    if (cBestadoCivil.Text.Trim() == "Casado" || cBestadoCivil.Text.Trim() == "Concubinato" || Convert.ToInt32(txFamiliaresACargo.Text.Trim()) > 0)
                    {
                        btAgregarFam.Show();
                        this.afiliadoFamiliar.nombre = txNombre.Text.Trim();
                        this.afiliadoFamiliar.apellido = txApellido.Text.Trim();
                        this.afiliadoFamiliar.id = AfiliadoManager.id(txDocumento.Text.Trim());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException fx)
                {
                    MessageBox.Show(fx.Message);
                }
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
            try
            {
                bool retornito = txNombre.Text.Trim() != "" && txApellido.Text.Trim() != "" &&
                    txTelefono.Text.Trim() != "" && txMail.Text.Trim() != "" &&
                    txDireccion.Text.Trim() != "" && txDocumento.Text.Trim() != "" &&
                    cBestadoCivil.Text.Trim() != "" && cBplanMedico.Text.Trim() != "" &&
                    cBsexo.Text.Trim() != "" && cBtipoDocumento.Text.Trim() != "";
                if (!retornito) {
                    MessageBox.Show("No puede haber campo vacios");
                    return retornito;
                }
                return Validacion.soloLetras(txNombre, "nombre") && Validacion.soloLetras(txApellido, "apellido") &&
                Validacion.soloNumeros(txTelefono, "telefono") && Validacion.emailValido(txMail) &&
                Validacion.esAlfanumerico(txDireccion, "direccion") && Validacion.soloNumeros(txDocumento, "documento") &&
                Validacion.soloNumeros(txFamiliaresACargo, "familiares") && Convert.ToInt32(txFamiliaresACargo.Text.Trim()) >= 0;
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
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
            form.setAfiliado(afiliadoFamiliar.id, afiliadoFamiliar.apellido);
            form.ShowDialog();
        }
        public void setAfiliado(int id, string ape)
        {
            afiliadoFamiliar.id = id;
            afiliadoFamiliar.apellido = ape;
            labelFamiliar.Text = "Ingresando familiar de:" + afiliadoFamiliar.apellido;
            labelFamiliar.Show();
            btAgregarFam.Text = "Agregar otro familiar";
        }

    }
}