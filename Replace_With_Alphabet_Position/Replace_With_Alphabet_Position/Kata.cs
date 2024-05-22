using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        var alphabet = new List<char>(){'0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                    'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                    's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        var reg = Regex.Matches(text, "[a-zA-Z]");
        text = string.Join("", reg);
        var charArray = text.ToLower().ToCharArray();

        var help = new List<int>();

        foreach (var c in charArray)
        {
            help.Add(alphabet.IndexOf(c));
        }

        return string.Join(" ", help);
    }
}