using BaseMundial.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Conexion
{
    internal class JugadoresCAD
    {
        public static bool GuardarJugadores(Jugadores e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO JugadoresInfo VALUES ('" + e.Id_jugadores + "', '" + e.Nombre + "', '" + e.Dorsal + "', '" + e.Id_pais + "', '" + e.Fecha + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else return false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable Listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  JugadoresInfo;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.desconectar();
                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Jugadores consultar(string id_jugador)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  JugadoresInfo WHERE Id_jugador ='" + id_jugador + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Jugadores em = new Jugadores();
                if (dr.Read())
                {
                    em.Id_jugadores = dr["Id_jugador"].ToString();
                    em.Nombre = dr["Nombre"].ToString();
                    em.Dorsal = Convert.ToInt32(dr["Dorsal"].ToString());
                    em.Id_pais = dr["Id_pais"].ToString();
                    em.Fecha = dr["Fecha"].ToString();
                    con.desconectar();
                    return em;
                }
                else
                {

                    con.desconectar();
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static bool actualizar(Jugadores e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE JugadoresInfo SET Nombre='" + e.Nombre + "',Dorsal='" + e.Dorsal + "',Id_pais='" + e.Id_pais + "',Fecha='" + e.Fecha + "' where Id_jugador='" + e.Id_jugadores + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool eliminar(string id_jugador)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM JugadoresInfo where Id_pais='" + id_jugador + "'";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
