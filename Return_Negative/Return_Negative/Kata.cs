using System;
using System.Collections.Generic;
using System.Text;

namespace Return_Negative
{
    public class Kata
    {
        public static int MakeNegative(int number)
        {
            if (number > 0) number = -number;
            return number;
        }
    }
}
