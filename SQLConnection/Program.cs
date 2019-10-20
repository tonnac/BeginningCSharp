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

                #region Insert Update Delete

                //cmd.CommandText = "insert into MemberInfo(Name, Birth, Email, Family) values('Fox', '1970-01-25', 'fox@gmail.com', 5)";
                //cmd.CommandText = "update MemberInfo set Family=3 where Email = 'fox@gmail.com'";
                //cmd.CommandText = "delete from MemberInfo where Email = 'fox@gmail.com'";
                int affectedCount = cmd.ExecuteNonQuery();
                Console.WriteLine(affectedCount);

                #endregion Insert Update Delete

                #region Select Execute Scalar

                //cmd.CommandText = "select count(*) from MemberInfo where Family >=2";
                //object objValue = cmd.ExecuteScalar();
                //int countOfMemeber = (int)objValue;

                #endregion Select Execute Scalar

                #region Select Execute Reader

                cmd.CommandText = "select * from MemberInfo";
                SqlDataReader reader = cmd.ExecuteReader();

                #endregion Select Execute Reader
            }
        }
    }
}