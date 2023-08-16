using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_remove_duplicates
{
    public class Solution
    {
        public static int[] solve(int[] arr)
        {
            var x = arr.Distinct().ToArray();
            return x;
        }
    }
}
