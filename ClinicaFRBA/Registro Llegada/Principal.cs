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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        buscarTurno buscador = new buscarTurno();

        private void button2_Click(object sender, EventArgs e)
        {
            buscador.ShowDialog();
            if (buscador.turnoSelect != null)
            {
                textBox2.Text = buscador.turnoSelect.id.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnosManager.PersistirCambios(buscador.turnoSelect);
            MessageBox.Show("Se registro la llegada del turno exitosamente!");
        }
    }
}
