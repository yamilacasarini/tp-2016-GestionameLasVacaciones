﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class mostrarTurno : Form
    {
        public Profesional profesional = new Profesional();
        public mostrarTurno()
        {
            InitializeComponent();
             this.dataGridView1.DataSource = llegadaMananger.buscarTurnoLibre(profesional);
            
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}