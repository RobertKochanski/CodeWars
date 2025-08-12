public class Kata
{
    public static int[] Ranks(int[] scores)
    {
        // Create an array of tuples (score, index) to keep track of original indices
        var scoreIndexPairs = scores.Select((score, index) => (score, index)).ToArray();

        // Sort the array based on scores in descending order
        var sortedScoreIndexPairs = scoreIndexPairs.OrderByDescending(pair => pair.score).ToArray();

        // Create an array to hold the ranks for each score in the original array
        var ranks = new int[scores.Length];

        int currentRank = 1;
        for (int i = 0; i < sortedScoreIndexPairs.Length; i++)
        {
            if (i > 0 && sortedScoreIndexPairs[i].score < sortedScoreIndexPairs[i - 1].score)
            {
                currentRank = i + 1;
            }

            // Assign the current rank to the original index of the score
            ranks[sortedScoreIndexPairs[i].index] = currentRank;
        }

        return ranks;
    }
}