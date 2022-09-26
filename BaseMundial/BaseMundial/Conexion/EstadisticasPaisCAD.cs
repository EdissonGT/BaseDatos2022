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
    internal class EstadisticasPaisCAD
    {
        public static bool GuardarEstadPais(EstadisticasPais e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO EstadSeleccion1 VALUES ('" + e.Id_pais + "', '" + e.Gol + "', '" + e.Tiros_marcos + "', '" + e.Tiros_des + "', '" + e.Tarjetas_amarillas + "', '" + e.Tarjetas_rojas + "')";
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
                string sql = "SELECT * FROM  EstadSeleccion1;";
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

        public static EstadisticasPais consultar(string id_pais)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  EstadSeleccion1 WHERE Id_pais ='" + id_pais + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                EstadisticasPais em = new EstadisticasPais();
                if (dr.Read())
                {
                    em.Id_pais = dr["Id_pais"].ToString();
                    em.Gol = Convert.ToInt32(dr["Gol"].ToString());
                    em.Tiros_marcos = Convert.ToInt32(dr["Tiros_marco"].ToString());
                    em.Tiros_des = Convert.ToInt32(dr["Tiros_des"].ToString());
                    em.Tarjetas_amarillas = Convert.ToInt32(dr["Tarjetas_amarillas"].ToString());
                    em.Tarjetas_rojas = Convert.ToInt32(dr["Tarjetas_rojas"].ToString());
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

        public static bool actualizar(EstadisticasPais e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE EstadSeleccion1 SET Gol='" + e.Gol + "',Tiros_marco='" + e.Tiros_marcos + "',Tiros_des='" + e.Tiros_des + "',Tarjetas_amarillas='" + e.Tarjetas_amarillas + "',Tarjetas_rojas='" + e.Tarjetas_rojas + "' where Id_pais='" + e.Id_pais + "'";
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
                string sql = "DELETE FROM EstadSeleccion1 where Id_pais='" + id_pais + "'";
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
