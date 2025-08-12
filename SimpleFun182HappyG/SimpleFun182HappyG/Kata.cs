using System;

public class Kata
{
    public bool HappyG(string str)
    {
        if (str.Length <= 1) return false;
        if (!str.Contains('g')) return true;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'g')
            {
                if ((i > 0 && str[i - 1] == 'g') || (i < str.Length - 1 && str[i + 1] == 'g'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}