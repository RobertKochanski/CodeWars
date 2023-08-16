using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_with_digits
{
    public class DigPow
    {
        public static int digPow(int x, int y)
        {
            double result = 0;

            int tempX = x;
            List<int> digits = new List<int>();
            while (tempX > 0)
            {
                digits.Add(tempX % 10);
                tempX /= 10;
            }

            digits.Reverse();

            foreach (var digit in digits)
            {
                result += Math.Pow(digit, y++);
            }

            int k = (int)result / x;

            if (k * x == result)
            {
                return k;
            }
            else
            {
                return -1;
            }

        }
    }
}
