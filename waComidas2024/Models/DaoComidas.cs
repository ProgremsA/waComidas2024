using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace waComidas2024.Models
{
    public class DaoComidas
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        public string insertar(Comidas obj)
        {
            string msj = null;
            SqlCommand cmd = new SqlCommand("insert into Comidas values (@nom,@dia,@fec,@aut)", cn);
            cmd.Parameters.AddWithValue("@nom", obj.comcom);
            cmd.Parameters.AddWithValue("@dia", obj.diacom);
            cmd.Parameters.AddWithValue("@fec", obj.fechcom);
            cmd.Parameters.AddWithValue("@aut", obj.autor);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                msj = "Comida Insertada";
            }catch (SqlException ex) 
            {
                msj = ex.Message;
            }
            finally
            {
                cn.Close();
                cmd.Dispose();
            }
            return msj;
        }

    }
}