using System;
using System.Collections.Generic;

public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        var result = new List<string>();

        foreach (var w in words)
        {
            var w2 = w;
            if (w.Length == word.Length)
            {
                for (int i = 0; i < w.Length; i++)
                {
                    char c = word[i];
                    if (w2.Contains(c))
                    {
                        w2 = w2.Remove(w2.IndexOf(c), 1);
                    }
                }
                if (w2 == string.Empty)
                {
                    result.Add(w);
                }
            }
        }

        return result;
    }
}