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
namespace ClinicaFrba.Listados
{
    public partial class AfiliadoConMayorCantidadDeBonos : Form
    {
        public AfiliadoConMayorCantidadDeBonos(DateTime dia)
        {
            InitializeComponent();

            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.getPacientesConMasCompras('" + dia.ToString() + "','" + dia.AddMonths(6).ToString() + "')");
            List<Abm_Afiliado.Afiliado> afiliados = new List<Abm_Afiliado.Afiliado>();
            while (reader.Read())
            {
                Abm_Afiliado.Afiliado afiliado = new Abm_Afiliado.Afiliado();
                afiliado.id = Convert.ToInt32(reader["id"]);
                afiliado.nombre = Convert.ToString(reader["nombre"]);
                afiliado.apellido = Convert.ToString(reader["apellido"]);
                afiliado.cantFamiliares = Convert.ToInt32(reader["CantFamiliares"]);
                afiliados.Add(afiliado);
            }

            reader.Close();
            dataGridView1.DataSource = afiliados;
            dataGridView1.Columns["documento"].Visible = false;
            dataGridView1.Columns["tipoDocumento"].Visible = false;
            dataGridView1.Columns["direccion"].Visible = false;
            dataGridView1.Columns["telefono"].Visible = false;
            dataGridView1.Columns["email"].Visible = false;
            dataGridView1.Columns["fechaNacimiento"].Visible = false;
            dataGridView1.Columns["sexo"].Visible = false;
            dataGridView1.Columns["estadoCivil"].Visible = false;
            dataGridView1.Columns["cantConsultas"].Visible = false;
            dataGridView1.Columns["servicio"].Visible = false;


        }
    }
}
