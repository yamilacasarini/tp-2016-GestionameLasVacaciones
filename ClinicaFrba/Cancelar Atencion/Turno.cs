using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Cancelar_Atencion
{
    public class Turno
    {
        public int id { get; set; }
        public int idProfesional { get; set; }
        public String especialidad { get; set; }
        public int idPaciente { get; set; }
        public DateTime fecha { get; set; }
        public int baja { get; set; }
        public int tipoCancelacion { get; set; }
        public String motivo { get; set; }

        public Turno() { }


    }
}
