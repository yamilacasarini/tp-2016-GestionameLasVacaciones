using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba
{
    class Sesion
    {
        public string rol;
        private static Sesion instance;
        public Form anterior;
        public string usuario;
        public DateTime fecha;

        public static Sesion getInstance
        {
            get
            {
                return instance;
            }
        }

    }
}
