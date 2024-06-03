using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            bool IsGreaterThan5(int x)
            {
                return x > 5;
            }

            List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };

            intList.RemoveAll(IsGreaterThan5);

            foreach (int element in intList)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();

            List<int> intList2 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };

            intList2.RemoveRange(2, 3);

            foreach (int element in intList2)
            {
                Console.Write($"{element}, ");
            }

        }
    }
}
