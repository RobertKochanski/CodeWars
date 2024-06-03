using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_smallest
{
    public class Kata
    {
        public static int FindSmallestInt(int[] args)
        {
            return args.Min();

            //foreach (var element in args)
            //{
            //    if (result > element)
            //    {
            //        result = element;
            //    }
            //}

            //return result;
        }
    }
}
