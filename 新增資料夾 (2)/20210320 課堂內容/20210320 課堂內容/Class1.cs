using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace _20210320_課堂內容
{
    public class Class1
    {
        public static DataTable searchDB()
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=test; Integrated Security=true";

            string queryString = $@" SELECT * FROM Table_1;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, con);

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

        public static void deleteDB(string str)
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=test; Integrated Security=true";

            string queryString = $@"delete Table_1 where ID = @ID;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, con);

                command.Parameters.AddWithValue("@ID", str);

                try
                {
                    con.Open();

                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex);
                }

            }
        }

        public static DataTable searchID(string ID)
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=test; Integrated Security=true";

            string queryString = $@" SELECT * FROM Table_1 where ID = @ID;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, con);

                command.Parameters.AddWithValue("@ID", ID);

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