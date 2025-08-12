namespace myjinxin
{
    public class Kata
    {
        public int[][] ReverseOnDiagonals(int[][] matrix)
        {
            var result = matrix.Select(a => a.ToArray()).ToArray();
            var x = matrix[0].Length;

            for (int i = 0; i < x; i++)
            {
                result[i][i] = matrix[x-i-1][x-i-1];
                result[x-i-1][i] = matrix[i][x-i-1];
            }

            return result;
        }
    }
}