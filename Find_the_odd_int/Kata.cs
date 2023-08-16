using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_odd_int
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            var xd = new Dictionary<int, int>();

            for (int i = 0; i < seq.Length; i++)
            {
                if (!xd.ContainsKey(seq[i]))
                {
                    xd.Add(seq[i], 1);
                }
                else
                {
                    xd[seq[i]]++;
                }
            }

            foreach (var xdd in xd)
            {
                if (xdd.Value % 2 == 1)
                {
                    return xdd.Key;
                }
            }

            return -1;
        }
    }
}
