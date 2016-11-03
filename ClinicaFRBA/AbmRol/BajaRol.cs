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
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Por favor introduzca un nombre");
                return;
            }
            try{
                RolManager.noExisteElRol(txtNombre.Text.Trim());
            }
            catch(Exception b)
            {
                  MessageBox.Show("Error, el Rol que se quiere eliminar no existe");
                  return;
            }
            if (RolManager.obtenerBaja(txtNombre.Text.Trim()) == 1)
            {
                MessageBox.Show("El Rol ya fue anteriormente dado de baja");
            }
            else
            {
                RolManager.deshabilitarRol(txtNombre.Text.Trim());
                MessageBox.Show("El rol fue eliminado");
               
            }
            txtNombre.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
