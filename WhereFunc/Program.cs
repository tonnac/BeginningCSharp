using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereFunc
{
    static public class Util
    {
        public static IEnumerator<int> indices;

        public static IEnumerable<int> WhereFunc(this IEnumerable<bool> inst)
        {
            int i = 0;
            while (true)
            {
                if (inst.ToArray()[i] == true)
                {
                    yield return i;
                }
                i = (i + 1) % inst.Count();
            }
        }

        public static int? GetNextIndex()
        {
            indices.MoveNext();
            return indices.Current;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<bool> inc = new List<bool> { true, false, true, true };
            Util.indices = inc.WhereFunc().GetEnumerator();

            int? index0 = Util.GetNextIndex();
            int? index1 = Util.GetNextIndex();
            int? index2 = Util.GetNextIndex();
            int? index3 = Util.GetNextIndex();
            int? index4 = Util.GetNextIndex();
            int? index5 = Util.GetNextIndex();
            int? index6 = Util.GetNextIndex();
            int? index7 = Util.GetNextIndex();
            int? index8 = Util.GetNextIndex();
        }
    }
}