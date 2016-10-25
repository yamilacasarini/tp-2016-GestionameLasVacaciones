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
    public partial class BuscarAfiliados : Form
    {
        List<dataClass.afiliado> afiliados = new List<dataClass.afiliado>();
       public dataClass.afiliado afiliadoBuscado = new dataClass.afiliado();
        
        public BuscarAfiliados()
        {
            InitializeComponent();
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
                afiliado.tipoDocumento = reader["tipoDocumento"].ToString(); 
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
            dataGridView1.DataSource = afiliados;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                afiliadoBuscado.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                afiliadoBuscado.nombre = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                afiliadoBuscado.apellido = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                afiliadoBuscado.documento = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                afiliadoBuscado.direccion = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                afiliadoBuscado.telefono = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                afiliadoBuscado.email = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                afiliadoBuscado.fechaNacimiento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value);
                afiliadoBuscado.sexo = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                afiliadoBuscado.estadoCivil = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                afiliadoBuscado.cantFamiliares = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value);
                afiliadoBuscado.tipoDocumento = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
                this.Close();
            }
            else{
                MessageBox.Show("Seleccione una unica fila");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            afiliadoBuscado.id = -1;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = AfiliadoManager.BuscarAfiliados("abs", "afjdis", 1932);
        }
    }
}

