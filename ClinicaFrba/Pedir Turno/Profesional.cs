using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Pedir_Turno
{
    public class Profesional
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int documento { get; set; }
        public String tipoDocumento { get; set; }
        public String direccion { get; set; }
        public int telefono { get; set; }
        public String email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String sexo { get; set; }

    }
}
