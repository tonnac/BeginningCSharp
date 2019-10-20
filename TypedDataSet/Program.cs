using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TypedDataSet;
using TypedDataSet.TestDBDataSetTableAdapters;

namespace TypedDataSet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestDBDataSet ds = new TestDBDataSet();
            MemberInfoTableAdapter da = new MemberInfoTableAdapter();

            da.Insert("Julie", new DateTime(1985, 5, 6), "julie@naver.com", 1);

            da.Fill(ds.MemberInfo);

            foreach (TestDBDataSet.MemberInfoRow row in ds.MemberInfo)
            {
                Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", row.Name, row.Birth, row.Email, row.Family));
            }

            TestDBDataSet.MemberInfoRow[] rows = ds.MemberInfo.Select("Name = 'Julie'") as TestDBDataSet.MemberInfoRow[];

            rows[0].Name = "July";
            da.Update(rows[0]);

            da.Delete(rows[0].Name, rows[0].Birth, rows[0].Email, rows[0].Family);
        }
    }
}