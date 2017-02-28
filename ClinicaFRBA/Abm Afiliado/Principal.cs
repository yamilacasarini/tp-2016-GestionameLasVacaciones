﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                new AltaAfiliado().ShowDialog();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            new Baja().ShowDialog();
            }
            catch (FormatException fx)
            {
                MessageBox.Show(fx.Message);
            }
        }

        private void botonDeModificacion_Click(object sender, EventArgs e)
        {
            try{
                new modificarAfiliado().ShowDialog();
            }
            catch (Exception fx)
            {
        //        MessageBox.Show(fx.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new BuscarAfiliados().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BuscarModificaciones().ShowDialog();
        }


    }
}
