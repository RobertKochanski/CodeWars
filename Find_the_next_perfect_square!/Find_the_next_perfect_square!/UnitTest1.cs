using NUnit.Framework;

namespace Find_the_next_perfect_square_
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(155, ExpectedResult = -1)]
        [TestCase(121, ExpectedResult = 144)]
        [TestCase(625, ExpectedResult = 676)]
        [TestCase(319225, ExpectedResult = 320356)]
        [TestCase(15241383936, ExpectedResult = 15241630849)]
        public static long FixedTest(long num)
        {
            return Kata.FindNextSquare(num);
        }
    }
}