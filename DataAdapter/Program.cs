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

            DataSet ds = new DataSet();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from MemberInfo", sqlCon);
                sda.Fill(ds, "MemberInfo");
            }

            ds.WriteXml(Console.Out);
        }
    }
}