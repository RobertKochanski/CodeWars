using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Counting
{
    public class Kata
    {
        public static int CountBits(int n)
        {
            //int result = 0;
            //var ip = Convert.ToString(n, 2).ToCharArray().Where(x => x == '1').Count();

            //for (int i = 0; i < ip.Length; i++)
            //{
            //    if (ip[i] == '1')
            //    {
            //        result++;
            //    }
            //}

            //return result;
            return Convert.ToString(n, 2).ToCharArray().Where(x => x == '1').Count();
        }
    }
}
