using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _20210327上課內容
{
    public class Class1
    {
        static string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=財經系統;Integrated Security=true";
        public static DataTable showTotalDB()
        {
            string querystring = @"SELECT  * from Assets;";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(querystring, con);

                try
                {
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    reader.Close();

                    return dt;
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex);

                    return null;
                }
            }

        }
    }
}