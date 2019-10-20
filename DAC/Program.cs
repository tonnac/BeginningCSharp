using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

using System.Data.SqlClient;
using System.Data;

namespace SQLConnection
{
    internal class MemberInfo
    {
        public string Name;
        public DateTime Birth;
        public string Email;
        public byte Family;
    }

    internal class MemberInfoDAC
    {
        private SqlConnection _sqlCon;

        public MemberInfoDAC(SqlConnection sqlCon)
        {
            _sqlCon = sqlCon;
        }

        private void FillParameters(SqlCommand cmd, MemberInfo item)
        {
            SqlParameter paramName = new SqlParameter("Name", SqlDbType.NVarChar, 20);
            paramName.Value = item.Name;

            SqlParameter paramBirth = new SqlParameter("Birth", SqlDbType.Date);
            paramBirth.Value = item.Birth;

            SqlParameter paramEmail = new SqlParameter("Email", SqlDbType.NVarChar, 100);
            paramEmail.Value = item.Email;

            SqlParameter paramFamily = new SqlParameter("Family", SqlDbType.TinyInt);
            paramFamily.Value = item.Family;

            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramBirth);
            cmd.Parameters.Add(paramEmail);
            cmd.Parameters.Add(paramFamily);
        }

        public void Insert(MemberInfo item)
        {
            string txt = "insert into MemberInfo(Name, Birth, Email, Family) values(@Name, @Birth, @Email, @Family)";

            SqlCommand cmd = new SqlCommand(txt, _sqlCon);
            FillParameters(cmd, item);
            cmd.ExecuteNonQuery();
        }

        public void Update(MemberInfo item)
        {
            string txt = "update MemberInfo set Name = @Name, Birth = @Birth, Family = @Family where Email = @Email";

            SqlCommand cmd = new SqlCommand(txt, _sqlCon);
            FillParameters(cmd, item);
            cmd.ExecuteNonQuery();
        }

        public void Delete(MemberInfo item)
        {
            string txt = "delete from MemberInfo where Email = @Email";

            SqlCommand cmd = new SqlCommand(txt, _sqlCon);
            FillParameters(cmd, item);
            cmd.ExecuteNonQuery();
        }

        public MemberInfo[] SelectAll()
        {
            string txt = "select * from MemberInfo";
            ArrayList list = new ArrayList();

            SqlCommand cmd = new SqlCommand(txt, _sqlCon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    MemberInfo item = new MemberInfo();
                    item.Name = reader.GetString(0);
                    item.Birth = reader.GetDateTime(1);
                    item.Email = reader.GetString(2);
                    item.Family = reader.GetByte(3);

                    list.Add(item);
                }
            }

            return list.ToArray(typeof(MemberInfo)) as MemberInfo[];
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

            MemberInfo item = new MemberInfo();
            item.Name = "Jennifer";
            item.Birth = new DateTime(1985, 5, 6);
            item.Email = "jennifer@jennifersoft.com";
            item.Family = 0;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                MemberInfoDAC dac = new MemberInfoDAC(sqlCon);
                dac.Insert(item);

                item.Name = "Jenny";
                dac.Update(item);

                MemberInfo[] list = dac.SelectAll();

                foreach (MemberInfo member in list)
                {
                    Console.WriteLine(member.Email);
                }

                dac.Delete(item);
            }
        }
    }
}