using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Registro_Llegada
{
     public class Turno
     {
        public Int32 id { get; set; }
        public Int32 idProfesional { get; set; }
        public String especialidad { get; set; }
        public Int32 idPaciente { get; set; }
        public DateTime fecha { get; set; }
        public Int32 baja { get; set; }
        public Int32 tipoCancelacion { get; set; }
        public String motivo { get; set; }
    }
}
