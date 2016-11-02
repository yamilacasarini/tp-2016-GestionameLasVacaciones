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
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RolManager.deshabilitarRol(txtNombre.Text.Trim());
            MessageBox.Show("El rol fue eliminado");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
