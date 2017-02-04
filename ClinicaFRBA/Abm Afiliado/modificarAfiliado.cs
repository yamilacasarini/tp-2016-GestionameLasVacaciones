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
        public Afiliado afiliado = new Afiliado();
        public modificarAfiliado()
        {
            InitializeComponent();
            BuscarAfiliados form = new BuscarAfiliados();

            form.ShowDialog();
            afiliado = form.afiliadoBuscado;
            if (afiliado.id != -1)
            {
                txApellido.Text = afiliado.apellido;
                txNombre.Text = afiliado.nombre;
                txDireccion.Text = afiliado.direccion;
                txDocumento.Text = Convert.ToString(afiliado.documento);
                txFamiliaresACargo.Text = Convert.ToString(afiliado.cantFamiliares);
                txMail.Text = afiliado.email;
                txTelefono.Text = afiliado.telefono;
                cBestadoCivil.Text = afiliado.estadoCivil;
                cBsexo.ValueMember = sexo(afiliado.sexo);
                cBtipoDocumento.Text = afiliado.tipoDocumento;
                dateTimePicker1.Value = afiliado.fechaNacimiento;
                if (afiliado.servicio != 0)
                {
                    txPlanMedico.Text = AfiliadoManager.planMedico(afiliado.servicio);
                    btAgregar.Show();
                    btAceptar.Show();
                    btCambiarPlan.Show();
                }
                else
                {
                    MessageBox.Show("No posee plan medico vigente a la fecha");
                    txPlanMedico.Hide();
                    btAgregar.Show();
                    btAceptar.Show();
                    btCambiarPlan.Show();
                }

            }
         //   btAceptar.Hide();
         //   btCambiarPlan.Hide();
         //   afiliado.id = -1;
         //   btAgregar.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void cBestadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        { }


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
                if (validarDatos())
                {
                    try{
                    AfiliadoManager.ModificarAfiliado(afiliado.id,txDireccion.Text.Trim(),txTelefono.Text.Trim(),txMail.Text.Trim(),
                        cBsexo.Text.Trim(), cBestadoCivil.Text.Trim(), Convert.ToInt32(txFamiliaresACargo.Text.Trim()));
                    this.Close();
                    }
                    catch (FormatException fx)
                    {
                        MessageBox.Show(fx.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Falta algun dato");
                }
            }
  

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            /*
            BuscarAfiliados form = new BuscarAfiliados();

            form.ShowDialog();
            afiliado = form.afiliadoBuscado;
            if (afiliado.id != -1)
            {
                txApellido.Text = afiliado.apellido;
                txNombre.Text = afiliado.nombre;
                txDireccion.Text = afiliado.direccion;
                txDocumento.Text = Convert.ToString(afiliado.documento);
                txFamiliaresACargo.Text = Convert.ToString(afiliado.cantFamiliares);
                txMail.Text = afiliado.email;
                txTelefono.Text = Convert.ToString(afiliado.telefono);
                cBestadoCivil.Text = afiliado.estadoCivil;
                cBsexo.ValueMember = sexo(afiliado.sexo);
                cBtipoDocumento.Text = afiliado.tipoDocumento;
                dateTimePicker1.Value = afiliado.fechaNacimiento;
                if (afiliado.servicio != 0)
                {
                    txPlanMedico.Text = AfiliadoManager.planMedico(afiliado.servicio);
                    btAgregar.Show();
                    btAceptar.Show();
                    btCambiarPlan.Show();
                }
                else
                {
                    MessageBox.Show("No posee plan medico vigente a la fecha");
                    txPlanMedico.Hide();
                    btAgregar.Show();
                    btAceptar.Show();
                    btCambiarPlan.Show();
                }

            }*/

        }
        private String sexo(string genero) {
            if (String.Compare(genero,"f")==0);
                return "Femenino";
            if (String.Compare(genero,"m")==0);
                return "Masculino";
            return "";
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
            txPlanMedico.Show();
            this.Show();
            if (afiliado.servicio != 0)
                txPlanMedico.Text = AfiliadoManager.planMedico(afiliado.servicio);

        }

        private void txNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void modificarAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AltaAfiliado form = new AltaAfiliado();
            form.setAfiliado(afiliado.id, afiliado.apellido);
            form.ShowDialog();
        }
    }
}
