using System;
using System.Collections.Generic;

public class ProdFib
{
    public static ulong[] productFib(ulong prod)
    {
        List<ulong> fibonacci = new List<ulong>() { 0, 1 };
        int n = 1;

        while (fibonacci[n] * fibonacci[n - 1] < prod)
        {
            fibonacci.Add(fibonacci[n] + fibonacci[n - 1]);
            n++;
        }

        ulong tf = (ulong)((fibonacci[n - 1] * fibonacci[n] == prod) ? 1 : 0);

        return new ulong[] { (ulong)fibonacci[n - 1], (ulong)fibonacci[n], tf };
    }
}