namespace Between_Extremes;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(new int[] { 21, 34, 54, 43, 26, 12 }, ExpectedResult = 42)]
    [TestCase(new int[] { -1, -41, -77, -100 }, ExpectedResult = 99)]
    public static int FixedTest(int[] numbers)
    {
        return Kata.BetweenExtremes(numbers);
    }
}