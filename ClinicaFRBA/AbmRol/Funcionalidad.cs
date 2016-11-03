using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.AbmRol
{
    class Funcionalidad
    {
        public int id {get; set;}
        public String descripcion {get; set;}

        public Funcionalidad() { }

        public Funcionalidad(int unId, String unaDescripcion)
        {
            this.id = unId;
            this.descripcion = unaDescripcion;
        }
  
    }
}
