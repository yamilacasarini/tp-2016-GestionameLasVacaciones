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
        public Profesional profSeleccionado { get; set; }

        public static Profesional BuscarUnProfesional(Int32 matricula) {

            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarProfesionales('" + "','" +"', '" + "'," + matricula+ ")");
            Profesional prof = new Profesional();
            while (reader.Read())
            {
                
                prof.matricula = Convert.ToInt32(reader["id"]);
                prof.nombre = reader["nombre"].ToString();
                prof.apellido = reader["apellido"].ToString();
                
            }
            reader.Close();
            return prof;
        }
        public static List<Profesional> BuscarProfesionales(String nombre, String apellido, String especialidad, int id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarProfesionales('" + nombre + "','" + apellido + "', '" + especialidad + "'," + id + ")");
            List<Profesional> profesionales = new List<Profesional>();
            while (reader.Read())
            {
                Profesional prof = new Profesional();
                prof.matricula = Convert.ToInt32(reader["id"]);
                prof.nombre = reader["nombre"].ToString();
                prof.apellido = reader["apellido"].ToString();
                prof.especialidad = reader["especialidad"].ToString();
                profesionales.Add(prof);
            }
            reader.Close();
            return profesionales;
        }

        public static List<DateTime> MostrarTurnosDeProfesional(int id, string especialidad)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.getHorarioDeAtencionDelProfesional(" + id + ", '" + especialidad + "', '" + Program.horarioSistema + "')");

            DateTime inicio = DateTime.Now;
            DateTime fin = DateTime.Now;

            List<DateTime> turnos = new List<DateTime>();

            List<DateTime> turnosNoDisponibles = new List<DateTime>();
            List<DateTime> turnosAMostrar = new List<DateTime>();

            int diaInicio = 0;
            int diaFin = 0;

            DateTime aux;

            int i = 0;
            int j = 0;

            int anio = Convert.ToInt32(Program.horarioSistema[0].ToString() + Program.horarioSistema[1].ToString() + Program.horarioSistema[2].ToString() + Program.horarioSistema[3].ToString());
            int dia = Convert.ToInt32(Program.horarioSistema[5].ToString() + Program.horarioSistema[6].ToString());
            int mes = Convert.ToInt32(Program.horarioSistema[8].ToString() + Program.horarioSistema[9].ToString());

            DateTime horaDelSistema = Convert.ToDateTime(anio + "/" + mes + "/" + dia);

            while (reader.Read())
            {

                inicio = (Convert.ToDateTime(reader["fechaInicio"].ToString()));
                fin = (Convert.ToDateTime(reader["fechaFinal"].ToString()));

                SqlDataReader reader3 = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.getDiasDeAtencionDelProfesional(" + id + ", '" + especialidad + "', '" + Program.horarioSistema + "','" + inicio + "','" + fin + "')");

                diaInicio = 0;
                diaFin = 0;

                while (reader3.Read())
                {

                    diaInicio = (Convert.ToInt32(reader3["diaInicio"]));
                    diaFin = (Convert.ToInt32(reader3["diaFin"]));
                }

                reader3.Close();

                aux = inicio;

                while (aux != fin)
                {
                    turnos.Add(aux);
                    aux = aux.AddMinutes(30);

                }

                for (i = 0; i < turnos.Count(); i++)
                {

                    if (((int)turnos[i].DayOfWeek >= diaInicio && (int)turnos[i].DayOfWeek <= diaFin)
                        && (!(turnos[i].Hour < inicio.Hour) && !(turnos[i].Hour >= fin.Hour)) && turnos[i].Date >= horaDelSistema)
                    {
                        turnosAMostrar.Add(turnos[i]);
                    }
                }

            }

            reader.Close();

            SqlDataReader reader2 = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.getTurnosAgendadosProfesional(" + id + ", '" + especialidad + "')");

            try
            {
                while (reader2.Read())
                {
                    turnosNoDisponibles.Add(Convert.ToDateTime(reader2[0]));
                }
            }
            catch (Exception)
            {
            }

            reader2.Close();

            for (j = 0; j < turnosNoDisponibles.Count(); j++)
            {
                if (turnosAMostrar.Contains(turnosNoDisponibles[j]))
                {
                    turnosAMostrar.Remove(turnosNoDisponibles[j]);
                }
            }


            return turnosAMostrar;

        }
    }

}