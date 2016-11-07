﻿using System;
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
    public partial class EspecialidadesConMasConsultas : Form
    {
        public EspecialidadesConMasConsultas(DateTime fecha)
        {
            InitializeComponent();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  * from GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas('" + fecha.ToString() + "','" + fecha.AddMonths(6).ToString() + "')");
            List<String> especialidades = new List<string>();
            while (reader.Read())
            {
                String nombreDeEspecialidad = reader["descripcion"].ToString();
                especialidades.Add(nombreDeEspecialidad);
            }
            reader.Close();
            dataGridView1.DataSource = especialidades;
        }
    }
}