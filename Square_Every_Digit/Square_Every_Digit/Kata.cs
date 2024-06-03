using System;
using System.Collections.Generic;

namespace Square_Every_Digit
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            List<int> list = new List<int>();
            string result = "";

            while (n > 0)
            {
                list.Add((int)Math.Pow(n % 10, 2));
                n /= 10;
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                result += list[i].ToString();
            }

            return int.Parse(result);
        }
    }
}
