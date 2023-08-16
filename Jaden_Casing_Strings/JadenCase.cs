using System;
using System.Linq;
using System.Collections;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        return string.Join(" ", phrase.Split(" ").Select(x => char.ToUpper(x[0]) + x.Substring(1)));
    }
}