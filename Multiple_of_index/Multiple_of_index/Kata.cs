using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_of_index
{
    public static class Kata
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= xs.Count - 1; i++)
            {
                if (xs[i] % i == 0)
                {
                    result.Add(xs[i]);
                }
            }
            return result;
        }
    }
}
