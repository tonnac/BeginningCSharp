using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;

namespace SQLConnection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.ConnectionString = connectionString;
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;

                cmd.CommandText = "select * from MemberInfo";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        DateTime birth = reader.GetDateTime(1);
                        string email = reader.GetString(2);
                        byte family = reader.GetByte(3);

                        Console.WriteLine("{0}, {1}, {2}, {3}", name, birth, email, family);
                    }
                }
            }
        }
    }
}