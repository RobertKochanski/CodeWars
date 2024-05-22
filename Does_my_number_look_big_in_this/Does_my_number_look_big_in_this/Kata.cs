public class Kata
{
    public static bool Narcissistic(int value)
    {
        var result = 0;
        var startValue = value;
        var number = new List<int>();

        while (value > 0)
        {
            number.Add(value % 10);
            value /= 10;
        }

        foreach (var digit in number)
        {
            result += (int)Math.Pow(digit, number.Count);
        }

        return result == startValue;
    }
}