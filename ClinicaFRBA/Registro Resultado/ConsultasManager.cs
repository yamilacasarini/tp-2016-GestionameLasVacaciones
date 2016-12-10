using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.Registro_Resultado
{
    class ConsultasManager
    {

        public static List<Consulta> BuscarConsulta(String nombreProfesional, String apellidoProfesional, String numeroPaciente, String numeroTurno) {
            List<Consulta> consultas = new List<Consulta>();
            Server server = Server.getInstance();
            String query = "select c.id as 'idConsulta', c.fecha,t.id as 'idTurno',t.idPaciente from GESTIONAME_LAS_VACACIONES.ConsultasMedicas c join GESTIONAME_LAS_VACACIONES.Turnos t on t.id = c.idTurno join GESTIONAME_LAS_VACACIONES.Profesionales p on p.id = t.idProfesional where ";
            int cantParametros = 0;

            if (nombreProfesional != "") {
                    query += "p.nombre like '" + nombreProfesional + "'"; 
           

                cantParametros++;
            }
            if(apellidoProfesional != ""){
           if(cantParametros >0 )
               query += " and ";

                 query += "p.apellido like '" + apellidoProfesional+ "'"; 
           cantParametros++;
            }
            if(numeroTurno != ""){
           if(cantParametros >0 )
               query += " and ";
                    
                query += "t.id = " +numeroTurno; 
                cantParametros ++;
            }
            if(numeroPaciente != ""){
                if (cantParametros > 0)
                    query += " and ";
                query += "t.idPaciente = " + numeroPaciente;
            }
            SqlDataReader read = server.query(query);
            while (read.Read()) {
                Consulta con = new Consulta();
                con.id = Convert.ToInt32(read["idConsulta"]);
                con.IdTurno = Convert.ToInt32(read["idTurno"]);
                con.fecha = Convert.ToDateTime(read["fecha"]);
                consultas.Add(con);
            }
            read.Close();
            return consultas;
        
        }

    }
}
