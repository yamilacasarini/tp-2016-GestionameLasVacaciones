using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Alta_Agenda_Profesional
{
    public partial class BuscarProf : Form
    {
        Principal inst = null;
        public BuscarProf(Principal instancia)
        {
            inst = instancia;
            InitializeComponent();
        }

        bool validarDatos()
        {
            return nombre.Text.Trim() != "" || apellido.Text.Trim() != "" || matricula.Text.Trim() != "" || especialidad.Text.Trim() != "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (matricula.Text.Trim() == "") { matricula.Text = "-1"; }
                this.dataGridView1.DataSource = Pedir_Turno.ProfesionalManager.BuscarProfesionales(nombre.Text.Trim(), apellido.Text.Trim(), especialidad.Text.Trim(), Convert.ToInt32(matricula.Text.Trim()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Pedir_Turno.Profesional profesional = new Pedir_Turno.Profesional();
                profesional.matricula = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                profesional.nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                profesional.apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                profesional.especialidad = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                inst.setearLabelProf(profesional);

            }

            this.Close();
        }


    }
}
