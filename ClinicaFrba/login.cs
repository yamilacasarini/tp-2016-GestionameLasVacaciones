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
using System.Security.Cryptography;
using System.Text;
using ClinicaFrba;

namespace ClinicaFrba
{
    public partial class login : Form
    {

        Sesion sesion;
        public login()
        {
            InitializeComponent();
        }
        private void titulo_Click(object sender, EventArgs e)
        {
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                {
                    Server server = Server.getInstance();
                    try
                    {
                        byte[] bytes = Encoding.Unicode.GetBytes(txtPassword.Text.Trim());
                        SHA256Managed hashstring = new SHA256Managed();
                        byte[] hash = hashstring.ComputeHash(bytes);
                        string hashString = string.Empty;
                        foreach (byte x in hash)
                        {
                            hashString += String.Format("{0:x2}", x);
                        }
                        server.realizarQuery("EXEC GESTIONAME_LAS_VACACIONES.LoguearUsuario '" + txtUsuario.Text.Trim() + "', '" + hashString + "'");
                       new ValidacionDeRol(txtUsuario.Text.Trim()).Show();
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan algun dato");
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validarDatos()
        {
            return txtUsuario.Text.Trim() != "" && txtPassword.Text.Trim() != "";
        }
    }
}