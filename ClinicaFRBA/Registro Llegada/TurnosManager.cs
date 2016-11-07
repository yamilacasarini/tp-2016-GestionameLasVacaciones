using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.Registro_Llegada
{
    class TurnosManager
    {

        public static List<Turno> BuscarTurnos(String nombre, String apellido, String especialidad, String id)
        {
            Server server = Server.getInstance();
            if (id == "") { id = "-1"; }
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerTurnosDelprofesional (" + "'%" + nombre + "%'," + "'%" + apellido + "%'," + "'%" + especialidad + "%'," + id+ ")");
            List<Turno> turnos = new List<Turno>();
            while (reader.Read())
            {
                Turno turno = new Turno();
                turno.id = Convert.ToInt32(reader["id"]);
                turno.idPaciente = Convert.ToInt32(reader["idPaciente"]);
                turno.idProfesional = Convert.ToInt32(reader["idProfesional"]);
                turno.especialidad = Convert.ToString(reader["especialidad"]);
                turno.fecha = Convert.ToDateTime(reader["fecha"]);
                turnos.Add(turno);
            }
            reader.Close();
            return turnos;
        }
        public void persistirCambios(Turno unTurno) {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.registrarLlegada "+unTurno.idPaciente+","+unTurno.idProfesional+",'"+unTurno.especialidad+"'");
            reader.Close();
        }
    }
}
