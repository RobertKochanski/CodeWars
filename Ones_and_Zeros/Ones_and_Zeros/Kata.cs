using System;

namespace Solution
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] arr)
        {
            return Convert.ToInt32(string.Join("", arr), 2);
        }
    }
}