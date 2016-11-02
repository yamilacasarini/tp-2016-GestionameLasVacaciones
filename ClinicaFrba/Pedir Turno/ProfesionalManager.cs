using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.Pedir_Turno
{
    class ProfesionalManager
    {
        //   Server server = Server.getInstance();
        public static Profesional profSeleccionado { get; set; }

         

        public static List<Profesional> BuscarProfesionales(String nombre, String apellido, String especialidad, int id)
        {
            Server server = Server.getInstance();
            //ProfesionalManager.validarDato(nombre);
            //ProfesionalManager.validarDato(apellido);
            SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarProfesionales('" + nombre + "','" + apellido + "', '" + especialidad + "'," + id + ")");
            List<Profesional> profesionales = new List<Profesional>();
            while (reader.Read())
            {
                Profesional prof = new Profesional();
                prof.id = Convert.ToInt32(reader["id"]);
                prof.nombre = reader["nombre"].ToString();
                prof.apellido = reader["apellido"].ToString();
                prof.tipoDocumento = reader["tipoDocumento"].ToString();
                prof.documento = Convert.ToInt32(reader["documento"]);
                prof.direccion = reader["direccion"].ToString();
                prof.telefono = Convert.ToInt32(reader["telefono"]);
                prof.email = reader["email"].ToString();
                prof.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                prof.sexo = reader["sexo"].ToString();
                profesionales.Add(prof);
            }
            reader.Close();
            return profesionales;
        }


        public static void validarDato(String algo)
        {
            if (algo == "")
                algo = "*";
        }

        public static void ModificarAfiliado(int id, String nombre, String apellido, int documento,
            String direccion, int telefono, String mail, char sexo, String estadoCivil, int CantidadFamiliares)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.modificarPaciente '" + id.ToString() + "','%" + nombre + "%','%" + apellido + "%'," + documento + ",'%" + direccion + "%'," + telefono.ToString() + ",'%" + mail + "%','%" + sexo.ToString() + "%','%" + estadoCivil + "%'");
            reader.Close();

        }
        public static string planMedico(int idServicio)
        {
            Server server = Server.getInstance();
            
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Planes WHERE id =" + idServicio);
            reader.Close();
            return Convert.ToString(reader["descripcion"]);
        }
        public static int idPlanMedico(String descripcion)
        {
            Server server = Server.getInstance();
            
            SqlDataReader reader = server.query("SELECT id FROM GESTIONAME_LAS_VACACIONES.Planes WHERE descripcion like '" + descripcion+"'");

            reader.Read();
            
            int retornito= Convert.ToInt32(reader["id"]);
            
            reader.Close();
           
            return retornito;
        }

        public static int id(string dni)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT id FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE documento =" + dni);
            reader.Read();
            int retornito = Convert.ToInt32(reader["id"]); // santi esto es por vos!!!!!
            reader.Close();
            return retornito;
        }

        public static void borrarAfiliado(int id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.borrarPaciente " + id);
            reader.Close();
            
        }
        /*         CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente(@id as int,@nombre as nvarchar(50), @apellido as nvarchar(50), 
     @doc as int, @direc as varchar(100), @tel as int, @mail as varchar(255), @sexo as char, @civil as varchar(10),
     @cantFami as int)*/
    }
}
