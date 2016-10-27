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
    public partial class cambiarPlan : Form
    {
        public Afiliado afiliado = new Afiliado();
        public cambiarPlan()
        {
            InitializeComponent();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT DISTINCT descripcion FROM GESTIONAME_LAS_VACACIONES.Servicio");

            while (reader.Read())
            {
                cBplanMedico.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
           
            if (validarDatos() && (String.Compare(AfiliadoManager.planMedico(afiliado.servicio), cBplanMedico.Text) != 0))
            {
                afiliado.servicio = AfiliadoManager.idPlanMedico(cBplanMedico.Text);
                Server server = Server.getInstance();
                SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.cambioPlan(" +
                    afiliado.id + "," + cBplanMedico.Text + "," + txtMotivo.Text.Trim() + ")");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan algun dato o es el mismo plan");
            }
        }

        private void cBplanMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool validarDatos()
        {
            return txtMotivo.Text.Trim() != "" && cBplanMedico.Text.Trim() != "";
        }

        private void cBplanMedico_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
