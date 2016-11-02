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

        public Principal()
        {
            InitializeComponent();
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.BuscarAfiliados busqueda = new Abm_Afiliado.BuscarAfiliados();
            busqueda.ShowDialog();
            afiliadoBuscado = busqueda.afiliadoBuscado;
            etiquetaPaciente.Text = afiliadoBuscado.id.ToString();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerPlanAcutalAfiliado(" + afiliadoBuscado.id.ToString() + ")");
            reader.Read();
            EtiquetaPlan.Text = reader["descripcion"].ToString();
            precioBono = Convert.ToInt16(reader["precioBono"]);
            reader.Close();
        }
    }
}
