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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Confirmacion : Form
    {
        DateTime fecha;
        Abm_Afiliado.Afiliado afiliado;
        Profesional profesional;

        public Confirmacion(DateTime f, Abm_Afiliado.Afiliado a, Profesional p)
        {
            fecha = f;
            afiliado = a;
            profesional = p;
            InitializeComponent();
            label2.Text = fecha.ToString();
            label5.Text = afiliado.apellido + "," + afiliado.nombre + ". Num De Afiliado: " + afiliado.id.ToString();
            label6.Text = profesional.apellido + "," + profesional.nombre + ". Especialidad: " + profesional.especialidad;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("exec GESTIONAME_LAS_VACACIONES.reservarTurno " + profesional.matricula + "," + afiliado.id + ",'" + profesional.especialidad + "','" + fecha.ToString() + "'");
            reader.Close();
        }
    }
}
