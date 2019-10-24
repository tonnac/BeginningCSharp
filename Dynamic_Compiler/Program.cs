using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace Dynamic_Compiler
{
    internal class Program
    {
        public static CallSite<Action<CallSite, object>> p_Site1;

        private static void Main(string[] args)
        {
            object d = 5;

            if (null == p_Site1)
            {
                p_Site1 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember
                    (CSharpBinderFlags.ResultDiscarded,
                    "CallTest", null, typeof(Program), new CSharpArgumentInfo[] {
                        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
                    }));

                p_Site1.Target(p_Site1, d);
            }
        }
    }
}