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
    internal class SeleccionCAD
    {
        public static bool GuardarSeleccion(Seleccion e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Seleccion VALUES ('" + e.Id_pais + "', '" + e.Pais + "', '" + e.Entrenador + "')";
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
                string sql = "SELECT * FROM  Seleccion;";
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

        public static Seleccion consultar(string id_pais)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM  Seleccion WHERE Id_pais ='" + id_pais + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Seleccion em = new Seleccion();
                if (dr.Read())
                {
                    em.Id_pais = dr["Id_pais"].ToString();
                    em.Entrenador = dr["Entrenador"].ToString();
                    em.Pais = dr["Pais"].ToString();
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

        public static bool actualizar(Seleccion e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE Seleccion SET Pais='" + e.Pais + "',Entrenador='" + e.Entrenador + "' where Id_pais='" + e.Id_pais + "'";
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

        public static bool eliminar(string Id_pais)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE FROM Seleccion where Id_pais='" + Id_pais + "'";
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
