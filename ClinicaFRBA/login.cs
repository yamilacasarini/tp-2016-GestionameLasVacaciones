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
        public static String usuario { get; set; }
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
                        Sesion s = Sesion.getInstance();
                        s.usuario = txtUsuario.Text.Trim();
                        SqlDataReader reader = server.query("select id from GESTIONAME_LAS_VACACIONES.Pacientes where usuario like '" + txtUsuario.Text.Trim() + "'");
                        if (reader.Read())
                        {
                            s.afiliado.id = Convert.ToInt32(reader[0]);
                            reader.Close();
                            s.afiliado = Abm_Afiliado.AfiliadoManager.BuscarUnAfiliado(s.afiliado.id);
                        }
                        else
                            reader.Close();
                        reader.Close();
                        reader = server.query("select id from GESTIONAME_LAS_VACACIONES.Profesionales where usuario like '" + txtUsuario.Text.Trim() + "'");
                        if (reader.Read())
                        {

                            s.profesional.matricula = Convert.ToInt32(reader[0]);
                            reader.Close();
                            s.profesional = Pedir_Turno.ProfesionalManager.buscarUnProfesional(s.profesional.matricula);
                        }
                        else
                            reader.Close();

                        new ValidacionDeRol(txtUsuario.Text.Trim()).ShowDialog();

                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
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