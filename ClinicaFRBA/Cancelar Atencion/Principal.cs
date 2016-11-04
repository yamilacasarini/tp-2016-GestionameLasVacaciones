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
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.BuscarAfiliados buscador = new Abm_Afiliado.BuscarAfiliados();
            buscador.ShowDialog();
            Abm_Afiliado.Afiliado afiliado = buscador.afiliadoBuscado;
            int afiliadoID = afiliado.id;
            
            new CancelacionAfiliado(afiliadoID).ShowDialog();
        }
    }
}
