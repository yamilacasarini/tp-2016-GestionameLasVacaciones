using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.Abm_Afiliado
{
    class AfiliadoManager
    {
        public static Afiliado afiliadoSeleccionado { get; set; }
        public static List<Afiliado> BuscarAfiliados(String nombre, String apellido, int id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT  * FROM GESTIONAME_LAS_VACACIONES.buscarAfiliados");
            List<Afiliado> afiliados = new List<Afiliado>();
            while (reader.Read())
            {
                Afiliado afiliado = new Afiliado();
                afiliado.id = (int)reader["id"];
                afiliado.nombre = reader["nombre"].ToString();
                afiliado.apellido = reader["apellido"].ToString();
                afiliado.sexo = reader["sexo"].ToString();
                afiliados.Add(afiliado);

            }
            reader.Close();
            return afiliados;
        }
        public static Afiliado BuscarAfiliado(int id)
        {
            Afiliado afil = new Afiliado();
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT  * FROM GESTIONAME_LAS_VACACIONES.Paciente where id ="+id.ToString());
                 while (reader.Read())
            {
                afiliadoSeleccionado.id = (int)reader["id"];
                afiliadoSeleccionado.nombre = reader["nombre"].ToString();
                afiliadoSeleccionado.apellido = reader["apellido"].ToString();
                afiliadoSeleccionado.sexo = reader["sexo"].ToString();
            }
            reader.Close();
           return afil;
        }
    }
}
