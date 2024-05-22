using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Sequence_Practice
{
    using System.Collections.Generic;

    public class SequenceSum
    {
        public static int[] SumOfN(int n)
        {
            var result = new List<int>();
            int x = 0;
            if (n > 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    x += i;
                    result.Add(x);
                }
            }
            else
            {
                for (int i = 0; i >= n; i--)
                {
                    x += i;
                    result.Add(x);
                }
            }

            return result.ToArray();
        }
    }
}
