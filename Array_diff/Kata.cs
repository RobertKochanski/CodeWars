using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_diff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> a_t = a.ToList();

            foreach (var b1 in b)
            {
                a_t.RemoveAll(x => x == b1);
            }

            return a_t.ToArray();
        }
    }
}
