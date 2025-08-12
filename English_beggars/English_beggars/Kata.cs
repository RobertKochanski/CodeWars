public class Kata
{
    public static int[] Beggars(int[] values, int n)
    {
        if (n == 0) return new int[n];

        int[] result = new int[n];

        for (int i = 0; i < values.Length; i++)
        {
            result[i % n] += values[i];
        }

        return result;
    }
}