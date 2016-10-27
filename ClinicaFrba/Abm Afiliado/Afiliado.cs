using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Afiliado
{
    class Afiliado
    {
       public int id {get; set;}
  public String nombre {get; set;}
  public String apellido { get; set; }
  public int documento {get; set;}
  public String tipoDocumento { get; set; }
  public String direccion { get; set; }
  public int telefono {get; set;}
  public String email { get; set; }
  public DateTime fechaNacimiento {get; set;}
  public String sexo {get; set;}
  public String estadoCivil { get; set; }
  public int cantFamiliares {get; set;}
  public int cantConsultas {get; set;}
  public int servicio {get; set;}


    }
}
