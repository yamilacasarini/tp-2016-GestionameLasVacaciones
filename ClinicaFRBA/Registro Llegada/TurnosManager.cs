﻿using System;
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
            List<Turno> turnos = new List<Turno>();
            string query = "SELECT t.id , t.fecha, t.idPaciente, t.especialidad, t.idProfesional FROM GESTIONAME_LAS_VACACIONES.Turnos t WHERE t.baja = 0 AND t.esConsulta = 0 AND " +
              "t.idProfesional  in (SELECT  p.id FROM GESTIONAME_LAS_VACACIONES.Profesionales p where p.nombre like ";
            if (!(nombre.Replace(" ", "") == ""))
                query += "'" + nombre + "'";
            else
                query += "'%'";
            if (!(apellido.Replace(" ", "") == ""))
                query += "and apellido like '" + apellido + "')";
            else
                query += "and apellido like '%')";
            if (!(especialidad.Replace(" ", "") == ""))
                query += " and t.especialidad like '" + especialidad + "'";
            if (id != "")
            {
                query += " and t.id =" + id + "";
            }
            query+= "and CAST(t.fecha AS DATE) = CAST(CAST('" + Program.horarioSistema.ToString() + "' AS DATETIME) AS DATE) and CAST(CAST('"+ Program.horarioSistema.ToString()+"' as DATETIME) AS TIME) < CAST(t.fecha AS TIME)";
            Server server = Server.getInstance();
            SqlDataReader reader = server.query(query);
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
        public static Int32 PersistirCambios(Turno unTurno)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.registrarLlegada " + unTurno.id + "," + unTurno.idPaciente + ",'" + Program.horarioSistema + "'");
            reader.Close();
            string q = "SELECT COUNT(*) as cantidad FROM GESTIONAME_LAS_VACACIONES.Bonos WHERE USADO = 0 AND idPaciente = " + unTurno.idPaciente;
            SqlDataReader reader1 = server.query("SELECT COUNT(*) FROM GESTIONAME_LAS_VACACIONES.Bonos WHERE USADO = 0 AND idPaciente = " + unTurno.idPaciente);
            reader1.Read();
            Int32 aux = Convert.ToInt32(reader1[0]);
            reader1.Close();
            return aux;
        }

        public static List<Especialidad> listarEspecialidades(int idMedico)
        {

            List<Especialidad> especialidades = new List<Especialidad>();
            string query = "select * from GESTIONAME_LAS_VACACIONES.Especialidades";

            if (idMedico > 0)
            {
                query += " e join GESTIONAME_LAS_VACACIONES.EspecialidadesxProfesional ep on (e.id = ep.idEspecialidad)" +
                    "where ep.idProfesional = " + idMedico;
            }

            Server server = Server.getInstance();
            SqlDataReader reader = server.query(query);
            while (reader.Read())
            {
                Especialidad esp = new Especialidad();
                esp.id = Convert.ToInt32(reader["id"]);
                esp.descripcion = reader["descripcion"].ToString();
                esp.tipoEspecialidad = Convert.ToInt32(reader["tipoEspecialidad"]);
                especialidades.Add(esp);
            }
            reader.Close();
            return especialidades;

        }
    }
}
