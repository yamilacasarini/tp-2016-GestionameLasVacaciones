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
namespace ClinicaFrba.Registro_Resultado
{
    public partial class Principal : Form
    {
        public Registro_Llegada.Turno turnoAdiagnosticar;
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnoAdiagnosticar = new Registro_Llegada.Turno();
            Registro_Llegada.buscarTurno buscador=  new Registro_Llegada.buscarTurno();
            buscador.ShowDialog();
            idTurno.Text = buscador.turnoSelect.id.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txSintomas.Text.Trim() != "" && txDiagnostico.Text.Trim() != "" && txDiagnostico.Text.Trim().Length < 255 && txSintomas.Text.Trim() != "")
            {
                Server server = Server.getInstance();
                SqlDataReader reader = server.query("UPDATE GESTIONAME_LAS_VACACIONES.ConsultasMedicas set diagnostico = '" + txDiagnostico.Text.Trim() + "', sintomas ='" + txSintomas.Text.Trim() + "' WHERE idTurno =" + idTurno.Text.ToString());
                reader.Close();
            }
            else
            {
                MessageBox.Show("Valores no fueron ingresados correctamente");
            }
               
        }
    }
}
