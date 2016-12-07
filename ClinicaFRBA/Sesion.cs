using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public class Sesion
    {
        public string rol{get;set;}
        public string usuario{get;set;}
        public Abm_Afiliado.Afiliado afiliado{get;set;}
        public Pedir_Turno.Profesional profesional{get;set;}
        public DateTime fecha;

        public static Sesion sesion{get;set;}

        public static Sesion getInstance()
        {
            if (sesion == null)
            {
                sesion = new Sesion();
                sesion.afiliado = new Abm_Afiliado.Afiliado();
                sesion.profesional = new Pedir_Turno.Profesional();
            }
            return sesion;
        }
    }
}
