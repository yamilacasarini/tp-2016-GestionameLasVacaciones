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
            SqlDataReader reader = server.query("SELECT DISTINCT descripcion FROM GESTIONAME_LAS_VACACIONES.Planes");

            while (reader.Read())
            {
                cBplanMedico.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
           // if (afiliado.servicio == 0)
           //     txMotivo.Hide();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacion.estaVacio(txtMotivo,"Motivo"))
                {
                    if (afiliado.servicio == 0)
                    {
                        afiliado.servicio = AfiliadoManager.idPlanMedico(cBplanMedico.Text);
                        AfiliadoManager.cambioPlan(afiliado.id, cBplanMedico.Text, txtMotivo.Text.Trim());
                        this.Close();
                    }
                    else if (String.Compare(AfiliadoManager.planMedico(afiliado.servicio), cBplanMedico.Text) != 0)
                    {
                        afiliado.servicio = AfiliadoManager.idPlanMedico(cBplanMedico.Text);
                        AfiliadoManager.cambioPlan(afiliado.id, cBplanMedico.Text, txtMotivo.Text.Trim());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya posee ese plan");
                    }
                }
            }
            catch(SqlException ex){
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void cBplanMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBplanMedico_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
