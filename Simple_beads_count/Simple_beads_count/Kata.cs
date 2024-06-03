using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_beads_count
{
    public static class Kata
    {
        public static int CountRedBeads(int n)
        {
            if (n < 2) return 0;

            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result += 2;
            }

            return result;
        }
    }
}
