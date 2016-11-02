using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.Registro_Llegada
{
    class LlegadaManager
    {
        
        public static void BuscarTurnos(String nombre, String apellido, String  especialidad,Int32 id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerTurnosDelprofesional("+"'%"+nombre+"%',"+"'%"+apellido+"%',"+"'%"+especialidad+"%',"+id.ToString()+")");
            while (reader.Read()) {
                Turno turno = new Turno();
                
            

            
            }
        }
    }
}
