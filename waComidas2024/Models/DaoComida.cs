using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace waComidas2024.Models
{
    public class DaoComida
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection cn = new SqlConnection(cadena);

        public List<Comidas> listar()
        {
            List<Comidas>listado = new List<Comidas>();
            SqlCommand cmd = new SqlCommand("select*from Comidas", cn);
            SqlDataReader dr = null;            
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    listado.Add(new Comidas(dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetString(3),dr.GetString(4)));
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                dr.Close();
                cn.Close();              
            }
            return listado;
        }
    }
}