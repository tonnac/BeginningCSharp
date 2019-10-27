using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParam
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region C# 6.0

            int outresult;
            int.TryParse("5", out outresult);

            #endregion C# 6.0

            #region C# 7.0

            int.TryParse("5", out int result);

            #endregion C# 7.0
        }
    }
}