﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.Abm_Afiliado
{
    class AfiliadoManager
    {
        //   Server server = Server.getInstance();
        public static Afiliado afiliadoSeleccionado { get; set; }
        public static List<Afiliado> BuscarAfiliados(String nombre, String apellido, int id)
        {
            List<Afiliado> afiliados = new List<Afiliado>();
           
                Server server = Server.getInstance();
                AfiliadoManager.validarDato(nombre);
                AfiliadoManager.validarDato(apellido);
                SqlDataReader reader = server.query("select * from GESTIONAME_LAS_VACACIONES.buscarAfiliados('" + nombre + "','" + apellido + "'," + id + ")");
                while (reader.Read())
                {
                    Afiliado afiliado = new Afiliado();
                    afiliado.id = Convert.ToInt32(reader["id"]);
                    afiliado.nombre = reader["nombre"].ToString();
                    afiliado.apellido = reader["apellido"].ToString();
                    afiliado.tipoDocumento = reader["tipoDocumento"].ToString();
                    afiliado.documento = Convert.ToInt32(reader["documento"]);
                    afiliado.direccion = reader["direccion"].ToString();
                    afiliado.telefono = Convert.ToInt32(reader["telefono"]);
                    afiliado.email = reader["email"].ToString();
                    afiliado.servicio = Convert.ToInt32(reader["planes"]);
                    afiliado.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                    afiliado.sexo = reader[10].ToString(); 
                    afiliado.estadoCivil = reader["estadoCivil"].ToString();
                    afiliado.cantFamiliares = Convert.ToInt32(reader["cantFamiliares"]);
                    afiliados.Add(afiliado);
                }
                reader.Close();
                return afiliados;
        }
        public static void validarDato(String algo)
        {
            if (algo == "")
            algo = '%' + algo +'%';
        }


        public static Boolean noTieneTurnosSinCancelar(int idAfiliado)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.obtenerTurnosNoCanceladosDelAfiliadoSegunId(" + idAfiliado + ",'" + Program.horarioSistema + "')");
            bool pudoLeer = reader.Read();
             reader.Close();
            if (!pudoLeer)
                return true;
            return false;
        }
        public static void ModificarAfiliado(int id,String direccion, int telefono, String mail,
            string sexo, String estadoCivil, int CantidadFamiliares)
        {
            Server server = Server.getInstance();
            string q = "EXEC GESTIONAME_LAS_VACACIONES.modificarPaciente " + id +
                ",'" + direccion + "'," + telefono + ",'" + mail + "'," + AfiliadoManager.genero(sexo) +
                ",'" + estadoCivil + "'," + CantidadFamiliares;
            SqlDataReader reader = server.query(q);
            reader.Close();

        }

        public static String planMedico(int idServicio)
        {
            Server server = Server.getInstance();

            SqlDataReader reader = server.query("SELECT * FROM GESTIONAME_LAS_VACACIONES.Planes WHERE id =" + idServicio.ToString());
            reader.Read();
            String descripcion = Convert.ToString(reader[3]);
            reader.Close();
            return descripcion;
        }

        public static int idPlanMedico(String descripcion)
        {
            Server server = Server.getInstance();

            SqlDataReader reader = server.query("SELECT id FROM GESTIONAME_LAS_VACACIONES.Planes WHERE descripcion like '" + descripcion + "'");

            reader.Read();

            int retornito = Convert.ToInt32(reader["id"]);

            reader.Close();

            return retornito;
        }

        public static int id(string dni)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("SELECT id FROM GESTIONAME_LAS_VACACIONES.Pacientes WHERE documento =" + dni);
            reader.Read();
            int retornito = Convert.ToInt32(reader["id"]); 
            reader.Close();
            return retornito;
        }

        public static void borrarAfiliado(int id)
        {
            Server server = Server.getInstance();
            SqlDataReader reader = server.query("EXEC GESTIONAME_LAS_VACACIONES.borrarPaciente " + id + ",'" + Program.horarioSistema + "'");
            reader.Close();

        }
        public static void cambioPlan(int id, string planMedico, string motivo)
        {
            int plan = AfiliadoManager.idPlanMedico(planMedico);
            Server server = Server.getInstance();
            String query = "EXEC GESTIONAME_LAS_VACACIONES.cambioPlan " + id +
                "," + plan + ",'" + motivo + "'";
            SqlDataReader reader = server.query(query);
            reader.Close();
        }
        public static void altaAfiliado(string nombre, string apellido, int documento, string direccion, int telefono,
            string mail, DateTime nacimiento, string sexo, string civil, int familiares, string descPlanMedico,int idFamiliar)
        {
            Server server = Server.getInstance();
            string query = "'" + nombre + "', '" + apellido + "'," + documento + ",'" + direccion + "'," + telefono +
                ",'" + mail + "','" + nacimiento + "','" + genero(sexo) + "','" + civil + "'," + familiares +
                ", " + AfiliadoManager.idPlanMedico(descPlanMedico);
            if (idFamiliar == 0)
            {
                server.realizarQuery("EXEC GESTIONAME_LAS_VACACIONES.altaPaciente " + query);
            }
            else {
                server.realizarQuery("EXEC GESTIONAME_LAS_VACACIONES.altaFamiliar " +idFamiliar + "," + query);
            }
        }
        public static char genero(string genero)
        {
            if (String.Compare(genero, "femenino") == 0)
                return 'f';
            return 'm';
        }
    }
}
