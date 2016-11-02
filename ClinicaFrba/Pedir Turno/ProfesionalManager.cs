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
            SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarProfesionales('" + nombre + "','" + apellido + "', '" + especialidad + "'," + id + ")");
            List<Profesional> profesionales = new List<Profesional>();
            while (reader.Read())
            {
                Profesional prof = new Profesional();
                prof.matricula = Convert.ToInt32(reader["idProf"]);
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
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.getHorarioDeAtencionDelProfesional(" + id + ", '" + especialidad + "')");
          
            List<DateTime> rango = new List<DateTime>();

            while (reader.Read())
            {
                rango.Add(Convert.ToDateTime(reader[0]));
                rango.Add(Convert.ToDateTime(reader[1]));
            }

            reader.Close();

            List<DateTime> turnos = new List<DateTime>();
            
             DateTime inicio = rango[0];
             DateTime fin = rango[1];

            while (inicio != fin)
            {
                turnos.Add(inicio);
                inicio = inicio.AddMinutes(30);

            }

            int i = 0;
            int j = 0;

            SqlDataReader reader2 = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.getTurnosAgendadosProfesional(" + id + ", '" + especialidad + "')");
            List<DateTime> turnosNoDisponibles = new List<DateTime>();

            while (reader2.Read())
            {
                turnosNoDisponibles.Add(Convert.ToDateTime(reader2[0]));
            }

            reader2.Close();

            System.Windows.Forms.MessageBox.Show(fin.TimeOfDay.ToString());

            while (i < turnos.Count())
            {
                j = 0;
                while (j < turnosNoDisponibles.Count())
                {

                    if (turnos[i] == turnosNoDisponibles[j] || turnos[i].TimeOfDay.CompareTo(fin.TimeOfDay) > 0 )
                        turnos.RemoveAt(i);
                        j++;
                }
                i++;
            }



            reader.Close();
            return turnos;

        }
       

    }
}
