using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba.AbmRol
{
    class RolManager
    {
        public static Rol rolSeleccionado { get; set; }
        public static Funcionalidad funcionalidadDeRol { get; set; }

        //MUESTRA LAS FUNCIONALIDADES SEGUN EL ROL ELEGIDO A TRAVES DE UNA FUNCION DE SQL
        public static List<Funcionalidad> mostrarFuncionalidades(String rol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerFuncionalidades( '" + rol + "' )");
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.id = Convert.ToInt32(reader["id"]);
                funcionalidad.descripcion = reader["descripcion"].ToString();
                funcionalidades.Add(funcionalidad);
            }
            reader.Close();
            return funcionalidades;

        }
        //MUESTRA TODAS LAS FUNCIONALIDADES DE LA TABLA FUNCIONALIDADES DE SQL
        public static List<Funcionalidad> mostrarTodasLasFuncionalidades()
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.Funcionalidades");
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.id = Convert.ToInt32(reader["id"]);
                funcionalidad.descripcion = reader["descripcion"].ToString();
                funcionalidades.Add(funcionalidad);
            }
            reader.Close();
            return funcionalidades;
        }
        //ELIMINA DE A UNA FUNCIONALIDAD, DADO EL ROL A TRAVES DE UN PROCEDURE
        public static void eliminarFuncionalidad(String rol, String funcionalidad)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.borrarFuncionalidadAUnRol '" + rol + "','" + funcionalidad + "'");
            reader.Close();

        }
        // AGREGA UN ROL A UN USUARIO, MODIFICANDO LA TABLA DE ROLES Y LA DE ROLES X USUARIO
        public static void agregarRol(String rol, String usuario)
        {

            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.crearRol '" + rol + "','" + usuario + "' ");
            reader.Close();
          
        }
        //AGREGA A LA TABLA DE FUNCIONALIDADES LA FUNCIONALIDAD Y TAMBIEN AGREGA UNA FILA A LA TABLA DE ROLES X FUNCIONALIDAD
        public static void agregarFuncionalidad(String rol, String funcionalidad)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol '" + rol + "','" + funcionalidad + "'");
            reader.Close();
        }
        // AGREGA TANTO EL ROL COMO FUNCIONALIDAD 
        public static void agregarRolYFuncionalidad(String rol, String funcionalidad)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.crearRol '" + rol + "'");
            reader.Close();
            reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.agregarFuncionalidadAUnRol '" + rol + "','" + funcionalidad + "'");
            reader.Close();
        }
        //OBTIENE UNA LISTA DE LAS FUNCIONALIDADES QUE NO ESTAN ASOCIADAS AL ROL, VERIFICANDOLO EN LA TABLA DE ROLES X FUNCIONALIDAD
        public static List<Funcionalidad> obtenerFuncionalidadesNoAgregadasEnRol(String rol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerFuncionesNoCargadasAUnRol ('" + rol + "')");
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.id = Convert.ToInt32(reader["id"]);
                funcionalidad.descripcion = reader["descripcion"].ToString();
                funcionalidades.Add(funcionalidad);
            }
            reader.Close();
            return funcionalidades;
        }
        //OBTIENE EL NUMERO DE BAJA DEL ROL. 1 SI FUE ELIMINADO, 0 SI NO
        public static int obtenerBaja(String rol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerBaja ('" + rol + "')");
            reader.Read();
            int baja = Convert.ToInt32(reader["baja"]);
            reader.Close();
            return baja;
        }
        // MODIFICA LA TABLA DE ROLES, PONIENDO EN 0 EL INT DE BAJA QUE ESTABA EN 1
        public static void habilitarRol(String rol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.habilitarRol '" + rol + "'");
            reader.Close();
        }
        // MODIFICA LA TABLA DE ROLES, PONIENDO EN 1 EL INT DE BAJA QUE ESTABA EN 0
        public static void deshabilitarRol(String rol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.borrarRol '" + rol + "'");
            reader.Close();
        }
        public static void eliminarRolPorUsuario(int idUsuario, String descripcionRol)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.borrarRolPaciente '" + idUsuario + "','" + descripcionRol + "'");
            reader.Close();
        }
        //MODIFICA LA TABLA DE ROLES, CAMBIANDO EL NOMBRE POR EL NUEVO
        public static void mofidicarNombre(String viejoNombre, String nuevoNombre)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.modificarRol '" + viejoNombre + "','" + nuevoNombre + "'");
            reader.Close();
        }
        //RETORNA UN BOOLEANO, CONSULTANDO SI EXISTE ALGUN DATO QUE COINCIDA CON LA DESCRIPCION DEL ROL. EN EL CASO DE QUE EXISTA, DEVUELVE TRUE. SINO FALSE
        public static bool existeElRol(String rol)
        {
            Server server = Server.getInstance();
            bool retorno;
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.Roles WHERE descripcion = '" + rol + "'");
            if (reader.Read())
                retorno = true;
            else
                retorno = false;
            reader.Close();
            return retorno;
        }

    }
}
