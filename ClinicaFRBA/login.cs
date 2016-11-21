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
                        int intentos = 0; 
                        String pass = " ";
                        using (SHA256 hash = SHA256Managed.Create())
                        {
                            Encoding enc = Encoding.UTF8;
                            Byte[] result = hash.ComputeHash(enc.GetBytes(txtPassword.Text.ToString()));

                            foreach (Byte b in result)
                                Sb.Append(b.ToString("x2"));
                        }
                        try
                        {
                            SqlDataReader reader = server.query("SELECT intentos, pass FROM GESTIONAME_LAS_VACACIONES.Usuarios WHERE usuario LIKE '" + txtUsuario.Text.Trim() + "'");
                            while (reader.Read())
                            {
                                intentos = Convert.ToInt32(reader[0]);
                                pass = reader[1].ToString(); 
                            }
                            reader.Close();

                            //Se desbloquea si vuelve a ingresar bien la contraseña 
                            if (intentos >= 3 && pass != Sb.ToString())
                            {
                                System.Windows.Forms.MessageBox.Show("Usuario bloqueado");
                                this.Close();
                            }
                            else
                            {
                                server.realizarQuery("EXEC GESTIONAME_LAS_VACACIONES.LoguearUsuario '" + txtUsuario.Text.Trim() + "', '" + Sb.ToString() + "'");
                                new ValidacionDeRol(txtUsuario.Text.Trim()).ShowDialog();
                            }
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

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}