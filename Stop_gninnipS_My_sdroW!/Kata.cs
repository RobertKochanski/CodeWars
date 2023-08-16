namespace Stop_gninnipS_My_sdroW_
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
            }

            return String.Join(" ", words);
        }
    }
}
