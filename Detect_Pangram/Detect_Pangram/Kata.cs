using System;
using System.Collections.Generic;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        var charArray = str.ToLower().ToCharArray();
        var alphabet = new List<char>(){'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                    'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                    's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        foreach (var c in charArray)
        {
            if (alphabet.Contains(c)) alphabet.Remove(c);
        }

        return alphabet.Count == 0 ? true : false;
    }
}