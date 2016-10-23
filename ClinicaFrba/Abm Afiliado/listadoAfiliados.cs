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
    public partial class listadoAfiliados : Form
    {
        List<dataClass.afiliado> afiliados = new List<dataClass.afiliado>();
        public listadoAfiliados()
        {
            InitializeComponent();
            cargarPacientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cargarPacientes()
        {
            SqlDataReader reader = Server.getInstance().query("SELECT id,nombre,apellido,dni,direccion,telefono,email,fechaNacimiento,sexo,estadoCivil,cantFamiliares" +
                "FROM GESTIONAME_LAS_VACACIONES.Paciente");
            while (reader.Read())
            {
                dataClass.afiliado afiliado = new dataClass.afiliado();
                afiliado.id = Convert.ToInt32(reader["id"]);
                afiliado.nombre = reader["nombre"].ToString();
                afiliado.apellido = reader["apellido"].ToString();
                afiliado.documento = Convert.ToInt32(reader["documento"]);
                afiliado.direccion = reader["direccion"].ToString();
                afiliado.telefono = Convert.ToInt32(reader["telefono"]);
                afiliado.email = reader["email"].ToString();
                afiliado.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                afiliado.sexo = reader["sexo"].ToString();
                afiliado.estadoCivil = reader["estadoCivil"].ToString();
                afiliado.cantFamiliares = Convert.ToInt32(reader["cantFamiliares"]);

                afiliados.Add(afiliado);
            }
            reader.Close();
        }
    }
}

