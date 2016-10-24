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

        public static Server server;
        private SqlDataReader reader;

        public AltaAfiliado()
        {
            InitializeComponent();
           llenarPlanes();
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
            reader = server.query("SELECT DISTINCT descripcion FROM GESTIONAME_LAS_VACACIONES.Servicio");

            while (reader.Read())
            {
                cBplanMedico.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Abm_Afiliado.Principal proximo = new Abm_Afiliado.Principal();
                proximo.Show();
                server.query("INSERT INTO GESTIONAME_LAS_VACACIONES.Paciente(nombre,apellido,documento,direccion,telefono,email,fechaNacimiento,sexo,EstadoCivil,cantFamiliares,servicio)" +
                "VALUES (" + txNombre.Text.Trim() + ", " + txApellido.Text.Trim() + "," + txDocumento.Text.Trim() + "," + txDireccion.Text.Trim() + "," + txTelefono.Text.Trim() +
                " " + txMail.Text.Trim() + "," + dateTimePicker1.Text.Trim() + "," + cBsexo.Text.Trim() + "," + cBestadoCivil.Text.Trim() + "," + txFamiliaresACargo.Text.Trim() +
                planMedico(cBplanMedico.Text.Trim()) + ",)");
                this.Close();
            }
            else {
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

        private string planMedico(string descripcion)
        {
            SqlDataReader reader = server.query("SELECT GESTIONAME_LAS_VACACIONES.getIdPlanMedico("+descripcion+")");
            return Convert.ToString(reader["id"]);
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
    }
}