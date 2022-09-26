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
    internal class GolCAD
    {
        public static bool GuardarGol(Gol e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO DetalleGol1 VALUES ('" + e.Id_detalle + "', '" + e.Seleccion + "', '" + e.Jug_gol + "', '" + e.Jug_asis + "', '" + e.Tipo_gol + "')";
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
                string sql = "SELECT * FROM  DetalleGol1;";
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

        public static Gol consultar(string id_detalle)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  DetalleGol1 WHERE Id_detalle ='" + id_detalle + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Gol em = new Gol();
                if (dr.Read())
                {
                    em.Id_detalle = dr["Id_detalle"].ToString();
                    em.Seleccion = dr["Seleccion"].ToString();
                    em.Jug_gol = dr["Jug_gol"].ToString();
                    em.Jug_asis = dr["Jug_asis"].ToString();
                    em.Tipo_gol = dr["Tipo_gol"].ToString();
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

        public static bool actualizar(Gol e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE DetalleGol1 SET Seleccion='" + e.Seleccion + "',Jug_gol='" + e.Jug_gol + "',Jug_asis='" + e.Jug_asis + "',Tipo_gol='" + e.Tipo_gol + "' where Id_detalle='" + e.Id_detalle + "'";
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

        public static bool eliminar(string id_detalle)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM DetalleGol1 where Id_detalle='" + id_detalle + "'";
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
