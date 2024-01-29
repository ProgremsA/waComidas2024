using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace waComidas2024.Models
{
    public class DaoBusqueda
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        public List<Comidas> consultar(Comidas obj)
        {
            List<Comidas> lista = new List<Comidas>();
            SqlCommand cmd = new SqlCommand("select * from Comidas where diaCom = @dia", cn);
            cmd.Parameters.AddWithValue("@dia", obj.diacom);            
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();                
                while (dr.Read())
                {
                    lista.Add(new Comidas( dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4)));
                }
                dr.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }                        
            finally
            {
                cn.Close();                
                cmd.Dispose();
            }
            return lista;
        }
    }
}