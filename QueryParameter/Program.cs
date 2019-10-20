using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace SQLConnection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            string name = "cooper";
            DateTime birth = new DateTime(1990, 2, 7);
            string email = "cooper@hotmail.com";
            int family = 5;

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.ConnectionString = connectionString;
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;

                SqlParameter paramName = new SqlParameter("Name", SqlDbType.NVarChar, 20);
                paramName.Value = name;

                SqlParameter paramBirth = new SqlParameter("Birth", SqlDbType.DateTime);
                paramBirth.Value = birth;

                SqlParameter paramEmail = new SqlParameter("Email", SqlDbType.NVarChar, 100);
                paramEmail.Value = email;

                SqlParameter paramFamily = new SqlParameter("Family", SqlDbType.TinyInt);
                paramFamily.Value = family;

                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramBirth);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramFamily);

                cmd.CommandText = "insert into MemberInfo(Name, Birth, Email, Family) values(@Name, @Birth, @Email, @Family)";
                cmd.ExecuteNonQuery();
            }
        }
    }
}