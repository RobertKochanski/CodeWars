using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_index_of_the_second
{
    public class Kata
    {
        public static int SecondSymbol(string str, char symbol)
        {
            return str.IndexOf(symbol, str.IndexOf(symbol) + 1);

            //var charArray = str.ToCharArray();

            //bool skip = true;

            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    if (charArray[i] == symbol && skip == true) skip = false;
            //    else if (charArray[i] == symbol && skip == false)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }
    }
}
