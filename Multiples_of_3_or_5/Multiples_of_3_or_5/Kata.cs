using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Multiples_of_3_or_5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            if (value < 0)
            {
                return 0;
            }

            //int result = 0;

            //for (int i = 0; i < value; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        result += i;
            //    }
            //}

            //return result;

            return Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
