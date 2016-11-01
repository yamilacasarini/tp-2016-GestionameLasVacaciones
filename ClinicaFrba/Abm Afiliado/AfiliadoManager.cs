using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.Abm_Afiliado
{
    class AfiliadoManager
    {
        //   Server server = Server.getInstance();
        public static Afiliado afiliadoSeleccionado { get; set; }
        public static List<Afiliado> BuscarAfiliados(String nombre, String apellido, int id)
        {
            Server server = Server.getInstance();
            AfiliadoManager.validarDato(nombre);
            AfiliadoManager.validarDato(apellido);
            SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarAfiliados('" + nombre + "','" + apellido + "'," + id + ")");
            List<Afiliado> afiliados = new List<Afiliado>();
            while (reader.Read())
            {
                Afiliado afiliado = new Afiliado();
                afiliado.id = Convert.ToInt32(reader["id"]);
                afiliado.nombre = reader["nombre"].ToString();
                afiliado.apellido = reader["apellido"].ToString();
                afiliado.tipoDocumento = reader["tipoDocumento"].ToString();
                afiliado.documento = Convert.ToInt32(reader["documento"]);
                afiliado.direccion = reader["direccion"].ToString();
                afiliado.telefono = Convert.ToInt32(reader["telefono"]);
                afiliado.email = reader["email"].ToString();
                afiliado.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                afiliado.sexo = reader["sexo"].ToString();
                afiliado.estadoCivil = reader["estadoCivil"].ToString();
                afiliado.cantFamiliares = Convert.ToInt32(reader["cantFamiliares"]);
                afiliados.Add(afiliado);
            }
            reader.Close();
            return afiliados;
        }
        public static void validarDato(String algo)
        {
            if (algo == "")
                algo = "*";
        }

        public static Afiliado BuscarAfiliado(string nombre, string apellido, int id)
        {
            Afiliado afil = new Afiliado();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("exec GESTIONAME_LAS_VACACIONES.buscarAfiliados(" + nombre + "," + apellido + "," + id + ")");

            while (reader.Read())
            {
                afiliadoSeleccionado.id = Convert.ToInt32(reader["id"]);
                afiliadoSeleccionado.nombre = reader["nombre"].ToString();
                afiliadoSeleccionado.apellido = reader["apellido"].ToString();
                afiliadoSeleccionado.tipoDocumento = reader["tipoDocumento"].ToString();
                afiliadoSeleccionado.documento = Convert.ToInt32(reader["documento"]);
                afiliadoSeleccionado.direccion = reader["direccion"].ToString();
                afiliadoSeleccionado.telefono = Convert.ToInt32(reader["telefono"]);
                afiliadoSeleccionado.email = reader["email"].ToString();
                afiliadoSeleccionado.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                afiliadoSeleccionado.sexo = reader["sexo"].ToString();
                afiliadoSeleccionado.estadoCivil = reader["estadoCivil"].ToString();
                afiliadoSeleccionado.cantFamiliares = Convert.ToInt32(reader["cantFamiliares"]);
            }
            reader.Close();
            return afil;
        }

        public static void ModificarAfiliado(int id, String nombre, String apellido, int documento,
            String direccion, int telefono, String mail, char sexo, String estadoCivil, int CantidadFamiliares)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.modificarPaciente '" + id.ToString() + "','%" + nombre + "%','%" + apellido + "%'," + documento + ",'%" + direccion + "%'," + telefono.ToString() + ",'%" + mail + "%','%" + sexo.ToString() + "%','%" + estadoCivil + "%'");


        }
        public static string planMedico(int idServicio)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT descripcion FROM GESTIONAME_LAS_VACACIONES.Servicio WHERE id =" + idServicio);
            return Convert.ToString(reader["descripcion"]);
        }
        public static int idPlanMedico(string descripcion)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT id FROM GESTIONAME_LAS_VACACIONES.Servicio WHERE descripcion =" + descripcion);
            return Convert.ToInt32(reader["id"]);
        }

        public static int id(string dni)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT id FROM GESTIONAME_LAS_VACACIONES.Paciente WHERE documento =" + dni);
            return Convert.ToInt32(reader["id"]);
        }

        public static void borrarAfiliado(int id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.borrarPaciente " + id);
           
            
        }
        /*         CREATE PROCEDURE GESTIONAME_LAS_VACACIONES.modificarPaciente(@id as int,@nombre as nvarchar(50), @apellido as nvarchar(50), 
     @doc as int, @direc as varchar(100), @tel as int, @mail as varchar(255), @sexo as char, @civil as varchar(10),
     @cantFami as int)*/
    }
}
