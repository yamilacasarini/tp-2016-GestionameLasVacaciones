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

    public partial class modificarAfiliado : Form
    {
        Afiliado afiliado = new Afiliado();
        public modificarAfiliado()
        {
            InitializeComponent();
            btAceptar.Hide();
            btCambiarPlan.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void cBestadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Server server = Server.getInstance();
                server.query("UPDATE GESTIONAME_LAS_VACACIONES.Paciente SET direccion =" +
             txDireccion.Text.Trim() + ", telefono =" + txTelefono.Text.Trim() + ", email =" + txMail.Text.Trim() + ", sexo=" +
             cBsexo.Text.Trim() + ", estadoCivil = " + cBestadoCivil.Text.Trim() + ", cantFamiliares = " + txFamiliaresACargo.Text.Trim() +
                 "WHERE id =" + afiliado.id);
                this.Close();

            }
            else
            {
                MessageBox.Show("Falta algun dato");
            }
        }

        private void txDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        bool validarDatos()
        {
            return txNombre.Text.Trim() != "" && txApellido.Text.Trim() != "" &&
                txTelefono.Text.Trim() != "" && txMail.Text.Trim() != "" &&
                txDireccion.Text.Trim() != "" && txDocumento.Text.Trim() != "" &&
                cBestadoCivil.Text.Trim() != "" &&
                cBsexo.Text.Trim() != "" && cBtipoDocumento.Text.Trim() != "" &&
                 Validacion.soloLetras(txNombre, "nombre") && Validacion.soloLetras(txApellido, "apellido") &&
            Validacion.soloNumeros(txTelefono, "telefono") && Validacion.emailValido(txMail) &&
            Validacion.esAlfanumerico(txDireccion, "direccion") && Validacion.soloNumeros(txDocumento, "documento");
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPlanMedico_TextChanged(object sender, EventArgs e)
        {

        }


        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarAfiliados form = new BuscarAfiliados();
            form.ShowDialog();
            if (form.afiliadoBuscado.id != -1)
            {
                afiliado = form.afiliadoBuscado;
                txApellido.Text = afiliado.apellido;
                txNombre.Text = afiliado.nombre;
                txDireccion.Text = afiliado.direccion;
                txDocumento.Text = Convert.ToString(afiliado.documento);
                txFamiliaresACargo.Text = Convert.ToString(afiliado.cantFamiliares);
                txMail.Text = afiliado.email;
                txTelefono.Text = Convert.ToString(afiliado.telefono);
                cBestadoCivil.Text = afiliado.estadoCivil;
                cBsexo.Text = afiliado.sexo;
                cBtipoDocumento.Text = afiliado.tipoDocumento;
                txPlanMedico.Text = AfiliadoManager.planMedico(form.afiliadoBuscado.id); // espero que funcione
                btAceptar.Show();
                btCambiarPlan.Show();
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCambiarPlan_Click_1(object sender, EventArgs e)
        {
            cambiarPlan form = new cambiarPlan();
            form.afiliado = afiliado;
            this.Hide();
            form.ShowDialog();
            btCambiarPlan.Hide();
            this.Show(); // hipoteticamente dicen que esto sucede recien cuando el form se cierra
        }

        private void txNombre_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
