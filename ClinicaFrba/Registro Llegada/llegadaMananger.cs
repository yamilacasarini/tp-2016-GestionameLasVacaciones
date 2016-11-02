using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.Registro_Llegada
{
    class llegadaMananger
    {
        public static List<Profesional> BuscarProfesionales(String nombre, String apellido, string especialidad)
        {
            List<Profesional> profesionales = new List<Profesional>();
                Server server = Server.getInstance();
                SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarProfesionales('" + nombre + "','" + apellido + "','" + especialidad + "',"+0+")");
                while (reader.Read())
                {
                    Profesional profesional = new Profesional();
                    profesional.id = Convert.ToInt32(reader["idProf"]);
                    profesional.especialidad = reader["especialidad"].ToString();
                    profesional.nombre = reader["nombre"].ToString();
                    profesional.apellido = reader["apellido"].ToString();
                    profesionales.Add(profesional);
                }
                reader.Close();
                return profesionales;
        }
    }
}
