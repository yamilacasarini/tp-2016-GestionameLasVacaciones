using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.Listados
{
    class ListadosManager
    {
        public static List<Especialidad> ObtenerProfesionalesConMasBonos(DateTime fecha)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  id, cantidadDeConsultas, especialidad from GESTIONAME_LAS_VACACIONES.topDeEspecialidadesConMasConsultas('" + fecha.ToString() + "','" + fecha.AddMonths(6).ToString() + "')");
            List<Especialidad> especialidades = new List<Especialidad>();
            while (reader.Read())
            {
                Especialidad unaEspecialidad = new Especialidad();
                unaEspecialidad.id = Convert.ToInt32(reader["id"]);
                unaEspecialidad.cantidadConsultas = Convert.ToInt32(reader["cantidadDeConsultas"]);
                unaEspecialidad.descripcion = reader["especialidad"].ToString();
                especialidades.Add(unaEspecialidad);
            }
            reader.Close();
            return especialidades;

        }
        public static List<ProfesionalesPorConsulta> ObtenerProfesionalesMasConsultados(int plan, DateTime desde, DateTime hasta) {

            List<ProfesionalesPorConsulta> profs = new List<ProfesionalesPorConsulta>();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  * from GESTIONAME_LAS_VACACIONES.getTop5Profesionales(" + plan + ",'" + desde.ToString() + "','" + hasta.ToString()+ "')");
            while (reader.Read())
            {
                ProfesionalesPorConsulta prof = new ProfesionalesPorConsulta();
                prof.idProfesional = Convert.ToInt32(reader["idProf"]);
                prof.cantidadDeConsultas = Convert.ToInt32(reader["cantConsultas"]);
                profs.Add(prof);
            }
            reader.Close();
            return profs;
        }
        public static List<Plan> obtenerLaListaDePlanes() {
            List<Plan> planes = new List<Plan>();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  id,descripcion from GESTIONAME_LAS_VACACIONES.Planes");
            while (reader.Read())
            {
                Plan plan = new Plan();
                plan.id = Convert.ToInt32(reader["id"]);
                plan.descripcion = reader["descripcion"].ToString();
                planes.Add(plan);
            }
            reader.Close();
            return planes;
        }
        public static List<Especialidad> obtenerEspecialidadesMedicas()
        {

            List<Especialidad> especialidades = new List<Especialidad>();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select  id,descripcion from GESTIONAME_LAS_VACACIONES.Especialidades");
            while (reader.Read())
            {
                Especialidad esp = new Especialidad();
                esp.id = Convert.ToInt32(reader["id"]);
                esp.descripcion = reader["descripcion"].ToString();
                especialidades.Add(esp);
            }
            reader.Close();
            return especialidades;
        }
        public static List<profMenosHoras> obtenerProfesionalesConMenosHoras(string descPlan, string descEspecialidad, DateTime desde, DateTime hasta)
        {
            List<profMenosHoras> profs = new List<profMenosHoras>();
            Server server = Server.getInstance();
            string query = "select id from GESTIONAME_LAS_VACACIONES.Planes where descripcion like '" + descPlan + "'";
            SqlDataReader reader = server.query(query);
            reader.Read();
            int plan = Convert.ToInt32(reader["id"]);
            reader.Close();
            query = "select id from GESTIONAME_LAS_VACACIONES.Especialidades where descripcion like '" + descEspecialidad + "'";
            SqlDataReader reader1 = server.query(query);
            reader1.Read();
            int especialidad = Convert.ToInt32(reader1["id"]);
            reader1.Close();
            query = "select  * from GESTIONAME_LAS_VACACIONES.topProfesionalesConMenosHoras(" + plan + "," +
                  especialidad + ",'" + desde.ToString() + "','" + hasta.ToString() + "')";
            SqlDataReader reader3 = server.query(query);
            while (reader3.Read())
            {
                profMenosHoras prof = new profMenosHoras();
                prof.horas = Convert.ToInt32(reader3[0]);
                prof.nombre = Convert.ToString(reader3[1]);
                prof.apellido = Convert.ToString(reader3[2]);
                profs.Add(prof);
            }
            reader3.Close();
            return profs;
        }
           
           
           }
    }
