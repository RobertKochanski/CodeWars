using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(13, ExpectedResult = true)]
    [TestCase(5, ExpectedResult = true)]
    [TestCase(9, ExpectedResult = false)]
    [TestCase(6, ExpectedResult = false)]
    [TestCase(11, ExpectedResult = false)]
    public static bool FixedTest(int p)
    {
        return Kata.AmIWilson(p);
    }
}