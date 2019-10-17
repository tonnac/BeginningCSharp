using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace StringAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();

            s.Start();

            string txt = "Hello World";
            #region 1
            //for (int i = 0; i < 300000; ++i)
            //{
            //    txt = txt + "1";
            //}
            #endregion

            #region 2

            StringBuilder sb = new StringBuilder();
            sb.Append(txt);

            for(int i=0; i< 300000; ++i)
            {
                sb.Append("1");
            }

            string newText = sb.ToString();

            #endregion

            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);
        }
    }
}
