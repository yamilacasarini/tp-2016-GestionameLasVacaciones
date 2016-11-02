using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.AbmRol
{
    class RolManager
    {
        public static Rol rolSeleccionado { get; set; }
        public static Funcionalidad funcionalidadDeRol {get; set;}
        public static List<Funcionalidad> mostrarFuncionalidades(String rol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades( '" + rol + "' )");
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
      
            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.id = Convert.ToInt32(reader["id"]);
                funcionalidad.descripcion = reader["descripcion"].ToString();
                funcionalidades.Add(funcionalidad);
            }
            reader.Close();
            return funcionalidades;

        }
    }
}
