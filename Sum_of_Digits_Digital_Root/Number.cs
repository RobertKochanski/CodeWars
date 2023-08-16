using System.Collections.Generic;
using System.Linq;

namespace Sum_of_Digits_Digital_Root
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            do
            {
                var numbers = new List<long>();

                while (n > 0)
                {
                    numbers.Add(n % 10);
                    n /= 10;
                }

                var sum = numbers.Sum();

                if (sum < 10)
                {
                    return (int)sum;
                }

                n = sum;

            } while (n >= 10);


            return 0;
        }
    }
}
