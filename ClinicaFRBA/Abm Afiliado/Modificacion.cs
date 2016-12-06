using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Afiliado
{
    class Modificacion
    {
          public int id  { get; set; }
          public int idPaciente { get; set; }
          public int idPlan  { get; set; }
          public string motivo  { get; set; }
          public DateTime fecha  { get; set; }
    }
}
