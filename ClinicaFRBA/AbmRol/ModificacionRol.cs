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

namespace ClinicaFrba.AbmRol
{
    public partial class ModificacionRol : Form
    {
        public ModificacionRol()
        {
            InitializeComponent();
            this.label4.Text = "";
            rellenarListaConRoles(Convert.ToString(login.usuario));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void rellenarListaConRoles(String id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Roles");
            while (reader.Read())
            {
                txtNombre.Items.Add(reader["descripcion"].ToString());
            }
            reader.Close();
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {
                   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            if(!RolManager.existeElRol(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Error, el rol buscado ya no existe");
                return;
            
            }
                    this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                    this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
                    int baja = RolManager.obtenerBaja(txtNombre.Text.Trim());
                    if (baja == 0)
                    {
                        this.label4.Text = "HABILITADO";
                    }
                    else
                    {
                        if (baja == 1)
                            this.label4.Text = "INHABILITADO";
                    }
                
            
           

            }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (this.dataGridView1.SelectedRows.Count)
            {
                case 0:
                    MessageBox.Show("Seleccione una funcionalidad");
                    break;
                case 1:
                    RolManager.eliminarFuncionalidad(txtNombre.Text.Trim(),
                        Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
                MessageBox.Show("Se ha eliminado la funcionalidad indicada");
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
                    break;
                default:
                         MessageBox.Show("Selecciona de a una funcionalidad");
                    break;

            }
                
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una funcionalidad para agregar");
            }
            else
            {

                DataGridViewSelectedRowCollection seleccion = this.dataGridView2.SelectedRows;
                foreach (DataGridViewRow funcionalidad in seleccion)
                {
                    RolManager.agregarFuncionalidad(this.txtNombre.Text, Convert.ToString(funcionalidad.Cells[1].Value));
                }

        

                MessageBox.Show("Las funcionalidades han sido agregadas al rol exitosamente");
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
            }
            

        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            if(this.label4.Text == "HABILITADO")
            {
                MessageBox.Show("El Rol ya esta habilitado");
                }
            else
            {
                if(this.label4.Text == "INHABILITADO")
                {
                    MessageBox.Show("Se ha habilitado el rol");
                    RolManager.habilitarRol(txtNombre.Text.Trim());
                    this.label4.Text = "HABILITADO";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNuevoNombre.Text.Trim()))
            {
                MessageBox.Show("Por favor introduzca un nombre");

            }
            else
            {
                if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Ingrese el nombre a querer modificar");
                    return;
                }
                if(RolManager.existeElRol(txtNuevoNombre.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un Rol con este nombre");
                    txtNuevoNombre.Clear();
                    return;
                }
                RolManager.mofidicarNombre(txtNombre.Text.Trim(), txtNuevoNombre.Text.Trim());
                MessageBox.Show("Nombre modificado exitosamente, vuelva a seleccionar un Rol");
                txtNombre.Items.Clear();
                rellenarListaConRoles(Convert.ToString(login.usuario));
                this.dataGridView1.DataSource = RolManager.mostrarFuncionalidades(txtNombre.Text.Trim());
                this.dataGridView2.DataSource = RolManager.obtenerFuncionalidadesNoAgregadasEnRol(txtNombre.Text.Trim());
                txtNuevoNombre.Clear();
                
            }

            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificacionRol_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
