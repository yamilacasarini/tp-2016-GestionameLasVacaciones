using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.Cancelar_Atencion
{
   public class CancelacionManager
    {
       public static void cancelarDiaProfesional(int idProfesional, DateTime dia, String motivo, String especialidad)
       {
           Server server = Server.getInstance();
           server.query("EXEC GESTIONAME_LAS_VACACIONES.cancelarDiaPorProfesional " + idProfesional + ",'" + especialidad + "','" + dia + "','" + motivo + "' ");
           server.closeReader();
       
       }
       public static void cancelarPeriodoProfesional(int idProfesional, DateTime diaInicial, DateTime diaFinal, String motivo, String especialidad)
       {
           Server server = Server.getInstance();
           server.query("EXEC GESTIONAME_LAS_VACACIONES.cancelarPeriodoPorProfesional " + idProfesional + ",'" + especialidad + "','" + diaInicial + "','" + diaFinal + "','" + motivo + "' ");
           server.closeReader();
       }
       public static List<Agenda> mostrarAgendaProfesional(int idProfesional)
       {
           Server server = Server.getInstance();
           SqlDataReader reader = server.query("SELECT id, idProfesional, idEspecialidad, fechaInicio, fechafinal, diaInicio, diaFin FROM GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelProfesionalSegunId( '" + idProfesional + "' )");
           List<Agenda> agendas = new List<Agenda>();
           if (!reader.Read())
           {
               reader.Close();
               return null;
           }
           while (reader.Read())
           {
               Agenda agenda = new Agenda();
               agenda.id = Convert.ToInt32(reader["id"]);
               agenda.idProfesional = Convert.ToInt32(reader["idProfesional"]);
               agenda.idEspecialidad = Convert.ToInt32(reader["idEspecialidad"]);
               agenda.fechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
               agenda.fechaFinal = Convert.ToDateTime(reader["fechaFinal"]);
               agenda.diaInicio = Convert.ToInt32(reader["diaInicio"]);
               agenda.diaFin = Convert.ToInt32(reader["diaFin"]);

               agendas.Add(agenda);
           }
           reader.Close();
           return agendas;       
       
       }
       public static List<Turno> mostrarTurnosAfiliado(int idAfiliado)
       {
           Server server = Server.getInstance();
           SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelAfiliadoSegunId(" + idAfiliado + ",'" + Program.horarioSistema + "')");
           List<Turno> turnos = new List<Turno>();

           while (reader.Read())
           {
               Turno turno = new Turno();
               turno.id = Convert.ToInt32(reader["id"]);
               turno.idProfesional = Convert.ToInt32(reader["idProfesional"]);
               turno.especialidad = reader["especialidad"].ToString();
               turno.idPaciente = Convert.ToInt32(reader["idPaciente"]);
               turno.fecha = Convert.ToDateTime(reader["fecha"]);
               turno.baja = Convert.ToInt32(reader["baja"]);
               if (reader.IsDBNull(reader.GetOrdinal("tipoCancelacion")))
                   turno.tipoCancelacion = -1;
               else
               {
                   turno.tipoCancelacion = Convert.ToInt32(reader["tipoCancelacion"]);
               }
                turno.motivo = reader["motivo"].ToString();
       
               turnos.Add(turno);
           }
           reader.Close();
           return turnos;       
       }

       public static void cancelarTurno(int idAfiliado, int idProfesional, String especialidad, String fecha, String motivo)
       {
           Server server = Server.getInstance();
           SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.cancelarTurnoPorAfiliado " + idAfiliado + "," + idProfesional + ",'" + especialidad + "','" + fecha + "','" + motivo + "','" + Program.horarioSistema +"'");
           reader.Close();
          
       
       }
    }
}
