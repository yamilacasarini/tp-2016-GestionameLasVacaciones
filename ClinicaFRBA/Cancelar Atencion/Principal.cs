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
    public partial class Principal : Form
    {
        public Pedir_Turno.Profesional profesional = new Pedir_Turno.Profesional();
        public Principal()
        {
            String rol = CancelacionManager.obtenerRolDeUsuario(login.usuario);
            
            InitializeComponent();
            if (rol == "Afiliado")
            {
                
                button1.Visible = false; ;

            }
            else
            {
                if (rol == "Profesional")
                {
                  
                    button2.Visible = false;
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.BuscarAfiliados buscador = new Abm_Afiliado.BuscarAfiliados();
            buscador.abrirCancelacion = 1;
            buscador.ShowDialog();
           
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedir_Turno.BuscarProfesional buscador = new Pedir_Turno.BuscarProfesional();
            buscador.ShowDialog();
            profesional = buscador.profesional;
            if (buscador.abrirCancelacion == 1)
            {
                Cancelar_Atencion.CancelacionMedico cancelacion = new Cancelar_Atencion.CancelacionMedico(profesional.matricula, profesional.especialidad);

                if (cancelacion.noAbrir != 1)
                    cancelacion.ShowDialog();
            }
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
