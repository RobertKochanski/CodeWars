using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hex_to_Decimal
{
    public class Kata
    {
        public static int HexToDec(string hexString)
        {
            //-------------Przy zastosowaniu Convert.ToInt32-----------------------------------

            char[] hexChar = hexString.ToCharArray();
            if (hexChar[0] != '-')
            {
                int decValue = Convert.ToInt32(hexString, 16);
                return decValue;
            }

            string temp = hexString.Substring(1);
            var negDecValue = Convert.ToInt32(temp, 16);

            return -negDecValue;

            //---------------------------------------------------------------------------------

            //var dupa = Convert.ToInt32(hexString.TrimStart('-'), 16);

            //return dupa * (hexString[0] == '-' ? -1 : 1);

            //-----------------Wszystko ręcznie---------------------------

            //double result = 0;

            //for (int i = hexChar.Length - 1; i >= 0; i--)
            //{

            //    if (hexChar[i] == '0') result += 0 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '1') result += 1 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '2') result += 2 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '3') result += 3 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '4') result += 4 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '5') result += 5 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '6') result += 6 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '7') result += 7 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '8') result += 8 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == '9') result += 9 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == 'A' || hexChar[i] == 'a') result += 10 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == 'B' || hexChar[i] == 'b') result += 11 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == 'C' || hexChar[i] == 'c') result += 12 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == 'D' || hexChar[i] == 'd') result += 13 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == 'E' || hexChar[i] == 'e') result += 14 * Math.Pow(16, hexChar.Length - 1 - i);
            //    if (hexChar[i] == 'F' || hexChar[i] == 'f') result += 15 * Math.Pow(16, hexChar.Length - 1 - i);

            //    if (hexChar[i] == '-')
            //    {
            //        result = -result;
            //    }
            //}
            //return result;

            //---------------------------------------------------------------------------------
        }
    }
}
