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
       public static List<Turno> mostrarTurnosAfiliado(int idAfiliado)
       {
           Server server = Server.getInstance();
           SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerTurnosDelAfiliadoSegunId( '" + idAfiliado + "' )");
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
               turno.tipoCancelacion = Convert.ToInt32(reader["tipoCancelacion"]);
                turno.motivo = reader["motivo"].ToString();
       
               turnos.Add(turno);
           }
           reader.Close();
           return turnos;       
       }
    }
}
