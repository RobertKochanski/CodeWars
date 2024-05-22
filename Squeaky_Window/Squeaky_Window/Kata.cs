using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaky_Window
{
    public class Kata
    {
        public static int[] Sliding(int[] nums, int k)
        {
            List<int> result = new List<int>();

            if (k == 1)
            {
                return nums;
            }

            for (int i = 0; i <= nums.Length - k; i++)
            {
                int max = nums[i];

                for (int j = 0; j < k; j++)
                {
                    if (max < nums[i + j])
                    {
                        max = nums[i + j];
                    }
                }
                result.Add(max);
            }

            return result.ToArray();
        }
    }
}
