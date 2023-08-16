using Chasers_schedule;

[TestFixture]
public static class ChaserTests
{
    private static void testing(int actual, int expected)
    {
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public static void NewbieRunner()
    {
        testing(Chaser.SpeedAndTime(2, 3), 8);
    }
    [Test]
    public static void LongDistanceRunner()
    {
        testing(Chaser.SpeedAndTime(49, 50), 2875);
    }
}