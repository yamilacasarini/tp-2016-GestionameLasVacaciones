using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.dataClass
{
    public class afiliado
    {
          public int id{get;set;}
          public string nombre { get; set; }
          public string apellido { get; set; }
          public int documento { get; set; }
          public string tipoDocumento { get; set; }
          public string direccion { get; set; }
          public int telefono { get; set; }
          public string email { get; set; }
          public DateTime fechaNacimiento { get; set; }
          public string sexo { get; set; }
          public string estadoCivil { get; set; }
          public int cantFamiliares { get; set; }
          public string planMedico { get; set; }
    }
}
