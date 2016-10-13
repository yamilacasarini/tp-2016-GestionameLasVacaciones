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

namespace ClinicaFrba.AbmRol
{
    public partial class crearRol : Form
    {
        SqlConnection conn;

        Sesion sesion = Sesion.Instance;
        Utilidades fun = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();
        public crearRol()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ABMRoles roles = new ABMRoles();
            roles.Show();
            this.Close();

        }
    }
}
