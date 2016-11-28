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
            SqlDataReader reader = server.query("select  id,descripcion from GESTIONAME_LAS_VACACIONES.Planes");
            while (reader.Read())
            {
                Especialidad esp = new Especialidad();
            }
            reader.Close();
            return especialidades;
        }
           
           
           }
    }