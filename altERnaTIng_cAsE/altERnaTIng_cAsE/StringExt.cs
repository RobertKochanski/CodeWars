using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altERnaTIng_cAsE
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (Char.IsLower(c))
                {
                    result += Char.ToUpper(c);
                }
                else
                {
                    result += Char.ToLower(c);
                }
            }

            return result;
        }
    }
}
