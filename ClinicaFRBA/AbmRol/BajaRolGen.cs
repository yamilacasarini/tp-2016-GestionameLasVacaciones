using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class BajaRolGen : Form
    {
        public Abm_Afiliado.Afiliado afiliado = new Abm_Afiliado.Afiliado();
        public BajaRolGen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.BuscarAfiliados buscadorAfiliado = new Abm_Afiliado.BuscarAfiliados();
            buscadorAfiliado.ShowDialog();
            afiliado = buscadorAfiliado.afiliadoBuscado;
            if (afiliado.id != -1)
            {
                new BajaRolPorUsuario(afiliado).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BajaRol().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
