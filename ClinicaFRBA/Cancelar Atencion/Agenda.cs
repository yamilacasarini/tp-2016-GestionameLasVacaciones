using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Cancelar_Atencion
{
    public class Agenda
    {
        public Agenda() { }

        public int id { get; set; }
        public int idProfesional { get; set; }
        public int idEspecialidad { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public int diaInicio { get; set; }
        public int diaFin { get; set; }
    }
}
