using System;

public class Kata
{
    public static bool AmIWilson(int p)
    {
        var result = 1;
        for (int i = 1; i <= p - 1; i++)
        {
            result *= i;
        }

        var x = (result + 1) / (p * p);

        return isPrime(x);
    }

    public static bool isPrime(int number)
    {
        if (number == 2) return true;
        if (number == 5) return true;

        var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

        for (int i = 2; i <= limit; ++i)
            if (number % i == 0)
                return false;
        return true;

    }
}