namespace Anagram_detection
{
    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            test = test.ToLower();
            original = original.ToLower();

            if (test.Length != original.Length)
            {
                return false;
            }

            foreach (char c in test)
            {
                if (original.Contains(c))
                {
                    original = original.Remove(original.IndexOf(c), 1);
                }
                else
                {
                    return false;
                }
            }

            if (original.Length != 0)
            {
                return false;
            }

            return true;
        }
    }
}
