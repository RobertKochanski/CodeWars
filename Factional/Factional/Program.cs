using System;
using System.Collections.Generic;
using System.Text;

namespace Factional
{
    public static class Program
    {

        public static int factorial(int n)
        {
            int result = 1;

            if (n == 0) return 1;

            for (; n > 0; n--)
            {
                result = result * n;
            }

            return result;
        }
    }
}
