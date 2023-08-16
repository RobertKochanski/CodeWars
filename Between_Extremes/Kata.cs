namespace Between_Extremes;

using System.Linq;

public class Kata
{
    public static int BetweenExtremes(int[] numbers)
    {
        numbers.Select(x => Math.Abs(x)).ToArray();

        return numbers.Max() - numbers.Min();
    }
}
