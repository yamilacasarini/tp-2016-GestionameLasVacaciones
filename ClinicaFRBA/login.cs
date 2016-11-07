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
using ClinicaFrba;

namespace ClinicaFrba
{
    public partial class login : Form
    {
        public static String usuario {get; set;}
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
            usuario = txtUsuario.Text.Trim();
            if (validarDatos())
            {
                {
                    Server server = Server.getInstance();
                        StringBuilder Sb = new StringBuilder();

                        using (SHA256 hash = SHA256Managed.Create())
                        {
                            Encoding enc = Encoding.UTF8;
                            Byte[] result = hash.ComputeHash(enc.GetBytes(txtPassword.Text.ToString()));

                            foreach (Byte b in result)
                                Sb.Append(b.ToString("x2"));
                        }
                        try
                        {
                            server.realizarQuery("EXEC GESTIONAME_LAS_VACACIONES.LoguearUsuario '" + txtUsuario.Text.Trim() + "', '" + Sb.ToString() + "'");
                            new ValidacionDeRol(txtUsuario.Text.Trim()).ShowDialog();
                        }
                        catch (SqlException)
                        {
                            System.Windows.Forms.MessageBox.Show("Contraseña y/o usuario incorrectos");
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