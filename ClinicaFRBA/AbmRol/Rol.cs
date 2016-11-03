using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.AbmRol
{
    public class Rol
    {
      public int id { get; set; }
      public String descripcion {get; set;}
      public int baja {get; set;}

      public Rol() { }

      public Rol(int unId, String unaDescrip, int unaBaja)
      {
          this.id = unId;
          this.descripcion = unaDescrip;
          this.baja = unaBaja;
      }
    }
}
