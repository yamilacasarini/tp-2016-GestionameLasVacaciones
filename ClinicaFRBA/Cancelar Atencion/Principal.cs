using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class Principal : Form
    {
        public Pedir_Turno.Profesional profesional = new Pedir_Turno.Profesional();
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.BuscarAfiliados buscador = new Abm_Afiliado.BuscarAfiliados();
            buscador.abrirCancelacion = 1;
            buscador.ShowDialog();
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedir_Turno.BuscarProfesional buscador = new Pedir_Turno.BuscarProfesional();
            buscador.abrirCancelacion = 1;
            buscador.ShowDialog();
            profesional = buscador.profesional;

            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
