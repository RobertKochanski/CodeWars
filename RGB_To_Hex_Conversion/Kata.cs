using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_To_Hex_Conversion
{
    public class Kata
    {
        public static string Rgb(int r, int g, int b)
        {
            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;

            string rValue = r > 255 ? "FF" : r.ToString("X");
            string gValue = g > 255 ? "FF" : g.ToString("X");
            string bValue = b > 255 ? "FF" : b.ToString("X");

            if (rValue.Length == 1) rValue = rValue.Insert(0, "0");
            if (gValue.Length == 1) gValue = gValue.Insert(0, "0");
            if (bValue.Length == 1) bValue = bValue.Insert(0, "0");

            return rValue + gValue + bValue;
        }
    }
}
