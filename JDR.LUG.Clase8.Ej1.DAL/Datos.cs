using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.LUG.Clase8.Ej1.DAL
{
    public class Datos
    {
        public SqlConnection conn;
        public void AbrirConexion()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=JDRASUSROG\SQLEXPRESS;Initial Catalog=Clase8;Integrated Security=True";
            conn.Open();
        }

        public void CerrarConexion()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
            GC.Collect();
        }

        public int Escribir(string store, Hashtable table)
        {
            int filas = 0;

            AbrirConexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;

            SqlTransaction tx = default(SqlTransaction);
            tx = conn.BeginTransaction(IsolationLevel.Serializable);

            if ((table != null))
            {
                foreach (string dato in table.Keys)
                {
                    //cargo los parametros que le estoy pasando con la Hash
                    cmd.Parameters.AddWithValue(dato, table[dato]);
                }
            }

            try
            {
                cmd.Transaction = tx;
                filas = cmd.ExecuteNonQuery();

                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();
            }

            CerrarConexion();

            return filas;
        }

        public DataTable Leer(string sp)
        {
            AbrirConexion();

            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sp, conn);
                da.Fill(dt);
            }
            catch (SqlException)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

            CerrarConexion();

            return dt;
        }
    }
}
