using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _20210328上課內容.Utility
{
    public class DBAccountManager
    {
        public static DataTable GetUserAccount(string account)
        {
            string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=UserAccount;Integrated Security=true";

            string querystring = @"SELECT  * from UserAccount where Account = @account;";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(querystring, con);

                command.Parameters.AddWithValue("@account", account);

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