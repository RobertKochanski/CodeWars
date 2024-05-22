using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Is_it_a_letter
{
    public class Kata
    {
        public static bool IsItLetter(char c)
        {
            if(Regex.IsMatch(c.ToString(), "[a-zA-Z]")) return true;
            return false;
        }
    }
}
