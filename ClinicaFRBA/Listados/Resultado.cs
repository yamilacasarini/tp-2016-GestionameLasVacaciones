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

namespace ClinicaFrba.Listados
{
    public partial class Resultado : Form
    {
        public Resultado(String tittle,SqlDataReader reader)
        {
            InitializeComponent();
        }
    }
}
