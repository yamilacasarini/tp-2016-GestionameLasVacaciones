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
    public partial class CancelacionAfiliado : Form
    {
        public CancelacionAfiliado(int id)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CancelacionManager.mostrarTurnosAfiliado(id);
        }

        private void CancelacionAfiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
