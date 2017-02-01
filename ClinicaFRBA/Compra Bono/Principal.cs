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
namespace ClinicaFrba.Compra_Bono
{
    public partial class Principal : Form
    {
        Abm_Afiliado.Afiliado afiliadoBuscado;
        int idPlan;
        int precioBono;
        Server server = Server.getInstance();
        Sesion sesion = Sesion.getInstance();
        public Principal()
        {
            InitializeComponent();
            if (sesion.rol == "Afiliado") {
                btBuscar.Hide();
                afiliadoBuscado = sesion.afiliado;
                etiquetaPaciente.Text = afiliadoBuscado.id.ToString();
                SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado(" + afiliadoBuscado.id.ToString() + ")");
                reader.Read();
                EtiquetaPlan.Text = reader["descripcion"].ToString();
                precioBono = Convert.ToInt16(reader["precioBono"]);
                reader.Close();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (etiquetaPaciente.Text.Trim() == "")
            {
                MessageBox.Show("Todavia no ingreso ningun paciente");
                cantidad.Value = 0;
            }
            else
            {
                etiquetaMonto.Text = (cantidad.Value * precioBono).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.BuscarAfiliados busqueda = new Abm_Afiliado.BuscarAfiliados();
            busqueda.ShowDialog();
            afiliadoBuscado = busqueda.afiliadoBuscado;
            if (afiliadoBuscado.id > 0)
            {
                etiquetaPaciente.Text = afiliadoBuscado.id.ToString();
                SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado(" + afiliadoBuscado.id.ToString() + ")");
                reader.Read();
                EtiquetaPlan.Text = reader["descripcion"].ToString();
                precioBono = Convert.ToInt16(reader["precioBono"]);
                reader.Close();
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (cantidad.Value > 0)
            {
                SqlDataReader read = server.query("EXEC GESTIONAME_LAS_VACACIONES.compraDeBonos '" + afiliadoBuscado.id.ToString() + "', '" + cantidad.Value.ToString() + "','" + Program.horarioSistema + "'");
                read.Close();
                MessageBox.Show("Compra realizada exitosamente!");
            }
            else
            {
                MessageBox.Show("La cantidad de bonos a comprar tiene que ser al menos 1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (etiquetaPaciente.Text.Trim() == "")
            {
                MessageBox.Show("Todavia no ingreso ningun paciente");
            }
            else
            {   
                SqlDataReader reader = null ;
                try{
                reader = server.query("select count (*) From GESTIONAME_LAS_VACACIONES.Bonos b where b.idPaciente/100 =" +etiquetaPaciente.Text.ToString()+"/100 and b.usado = 0");
                reader.Read();
                    MessageBox.Show("El usuario ahora poseee: " + reader.GetInt32(0).ToString()
                        + " bonos");
               
            }catch(Exception ex){
                MessageBox.Show(ex.Message); 
            }
                reader.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
