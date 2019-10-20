#define TransactionScope

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Transaction0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string txt = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(txt))
            {
#if TransactionScope
                using (TransactionScope tx = new TransactionScope())
                {
                    sqlCon.Open();
                    string isrt = "insert into MemberInfo(Name, Birth, Email, Family) values('{0}', '{1}', '{2}', '{3}')";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandText = string.Format(isrt, "Fox", "1970-01-25", "fox@gmail.com", 5);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format(isrt, "Dana", "1972-02-12", "fox@gmail.com", 1);
                    cmd.ExecuteNonQuery();

                    tx.Complete();
                }
#else
                sqlCon.Open();
                using (SqlTransaction transaction = sqlCon.BeginTransaction())
                {
                    string isrt = "insert into MemberInfo(Name, Birth, Email, Family) values('{0}', '{1}', '{2}', '{3}')";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.Transaction = transaction;
                    cmd.CommandText = string.Format(isrt, "Fox", "1970-01-25", "fox@gmail.com", 5);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format(isrt, "Dana", "1972-02-12", "fox@gmail.com", 1);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
#endif
            }
        }
    }
}