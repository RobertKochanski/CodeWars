using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_of_cubes
{
    public static class Kata
    {
        public static long SumCubes(int n)
        {
            long x = 0;
            for (; n > 0; n--)
            {
                x += n * n * n;
            }
            return x;
        }
    }
}
