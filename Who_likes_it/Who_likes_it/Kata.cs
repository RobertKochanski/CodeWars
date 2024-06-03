using System;
using System.Collections.Generic;
using System.Text;

namespace Who_likes_it
{
    public static class Kata
    {
        public static string Likes(string[] name)
        {
            string result = "";
            switch (name.Length)
            {
                case 0:
                    result = "no one likes this";
                    break;
                case 1:
                    result = $"{name[0]} likes this";
                    break;
                case 2:
                    result = $"{name[0]} and {name[1]} like this";
                    break;
                case 3:
                    result = $"{name[0]}, {name[1]} and {name[2]} like this";
                    break;
                default:
                    result = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
                    break;
            }

            return result;
            


            //if (name.Length == 1)
            //{
            //    return $"{name[0]} likes this";
            //}
            //if (name.Length == 2)
            //{
            //    return $"{name[0]} and {name[1]} like this";
            //}
            //if (name.Length == 3)
            //{
            //    return $"{name[0]}, {name[1]} and {name[2]} like this";
            //}
            //if (name.Length > 3)
            //{
            //    return $"{name[0]}, {name[1]} and {name.Length-2} like this";
            //}
            //return "no one likes this";
        }
    }
}
