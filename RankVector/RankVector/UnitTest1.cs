namespace Solution
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTests()
        {
            Assertion(new int[] { -1, 3, 3, 3, 5, 5 }, new int[] { 6, 3, 3, 3, 1, 1 });
            Assertion(new int[0], new int[0]);
            Assertion(new int[] { 2 }, new int[] { 1 });
            Assertion(new int[] { 2, 2 }, new int[] { 1, 1 });
            Assertion(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 });
            Assertion(new int[] { -5, -10, 3, 1 }, new int[] { 3, 4, 1, 2 });
            Assertion(new int[] { 1, 10, 4 }, new int[] { 3, 1, 2 });
            Assertion(new int[] { 5, 2, 3, 5, 5, 4, 9, 8, 0 }, new int[] { 3, 8, 7, 3, 3, 6, 1, 2, 9 });
        }

        private static void Assertion(int[] ranks, int[] expected)
        {
            int[] actual = Kata.Ranks(ranks);

            Assert.That(
              actual, Is.EqualTo(expected),

              $"\n  Ranks: [{string.Join(", ", ranks)}]\n" +
              $"\n  Expected: [{string.Join(", ", expected)}]" +
              $"\n  Actual: [{string.Join(", ", actual)}]\n"
            );
        }
    }
}
