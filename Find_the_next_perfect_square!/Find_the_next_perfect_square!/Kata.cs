using static System.Math;

namespace Find_the_next_perfect_square_
{
    public class Kata
    {
        public static long FindNextSquare(long num)
        {
            //var baseValue = Math.Sqrt(num);
            //var helpValue = (int)Math.Sqrt(num);
            //if (baseValue != helpValue) return -1;
            //baseValue++;

            //return (long)Math.Pow(baseValue, 2);

            return Sqrt(num) % 1 == 0 ? (long)Pow(Sqrt(num) + 1, 2) : -1;
        }
    }
}
