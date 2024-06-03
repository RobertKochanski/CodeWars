using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    public class Kata
    {
        public static string Join(List<string> list, char separator)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                if (i != list.Count - 1)
                {
                    sb.Append(separator);
                }
            }

            return sb.ToString();
        }

        public static List<string> Reverse(List<string> list)
        {
            var result = new List<string>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }

            return result;
        }

        public static List<string> Split(string str, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == separator)
                {
                    var word = str.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1;
                }
                else if(i == str.Length - 1)
                {
                    var word = str.Substring(currentIndex, str.Length - currentIndex);
                    result.Add(word);
                }
            }

            return result;
        }

        public static string ReverseWords(string str)
        {
            // Z ręcznie napisanych metod

            return Join(Reverse(Split(str, ' ')), ' ');


            // Z wykorzystaniem wbudowanych metod

            //var split = str.Split(' ');
            //var reversedWords = split.Reverse();
            //var result = string.Join(' ', reversedWords);

            //return result;

        }
    }
}
