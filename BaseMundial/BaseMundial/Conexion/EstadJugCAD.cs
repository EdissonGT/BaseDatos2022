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
    internal class EstadJugCAD
    {
        public static bool GuardarEstadJugador(EstadJug e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO EstadJug VALUES ('" + e.Id_jugador + "', '" + e.Goles + "', '" + e.Tiros_marc + "', '" + e.Tiros_des + "', '" + e.Tarjetas_amarillas + "', '" + e.Tarjetas_rojas + "','" + e.Minutos + "','" + e.Asistencias + "')";
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
                string sql = "SELECT * FROM  EstadJug;";
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

        public static EstadJug consultar(string id_jugador)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  EstadJug WHERE Id_jugador ='" + id_jugador + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                EstadJug em = new EstadJug();
                if (dr.Read())
                {
                    em.Id_jugador = dr["Id_jugador"].ToString();
                    em.Goles = Convert.ToInt32(dr["Goles"].ToString());
                    em.Tiros_marc = Convert.ToInt32(dr["Tiros_marc"].ToString());
                    em.Tiros_des = Convert.ToInt32(dr["Tiros_des"].ToString());
                    em.Tarjetas_amarillas = Convert.ToInt32(dr["Tarjetas_amarillas"].ToString());
                    em.Tarjetas_rojas = Convert.ToInt32(dr["Tarjetas_rojas"].ToString());
                    em.Minutos = Convert.ToInt32(dr["Minutos"].ToString());
                    em.Asistencias = Convert.ToInt32(dr["Asistencias"].ToString());
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

        public static bool actualizar(EstadJug e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE EstadJug SET Goles='" + e.Goles + "',Tiros_marc='" + e.Tiros_marc + "',Tiros_des='" + e.Tiros_des + "',Tarjetas_amarillas='" + e.Tarjetas_amarillas + "',Tarjetas_rojas='" + e.Tarjetas_rojas + "',Minutos='" + e.Minutos + "',Asistencias='" + e.Asistencias + "' where Id_jugador='" + e.Id_jugador + "'";
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

        public static bool eliminar(string id_pais)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM EstadJug where Id_jugador='" + id_pais + "'";
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
