using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Pig_Latin
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            var splited = str.Split(" ");

            for (int i = 0; i < splited.Length; i++)
            {
                if (splited[i] != "!")
                {
                    splited[i] = splited[i] + splited[i][0] + "ay";
                    splited[i] = splited[i].Remove(0, 1);
                }
            }

            return string.Join(" ", splited);
        }
    }
}
