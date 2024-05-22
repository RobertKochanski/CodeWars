using System;

public static class Kata
{
    public static string Order(string words)
    {
        var wordsList = words.Split(' ').ToList();
        Dictionary<int, string> dict = new Dictionary<int, string>();

        for (int i = 1; i <= wordsList.Count; i++)
        {
            dict.Add(i, wordsList.FirstOrDefault(x => x.Contains($"{i}")));
        }

        var result = new List<string>();

        foreach (var d in dict)
        {
            result.Add(d.Value);
        }

        return string.Join(" ", result);
    }
}