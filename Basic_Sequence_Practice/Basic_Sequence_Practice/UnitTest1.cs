
using Basic_Sequence_Practice;

[TestFixture]
public class SequenceSumTests
{
    [Test]
    public void Test_3()
    {
        int input = 3;
        int[] expected = new int[] { 0, 1, 3, 6 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Neg4()
    {
        int input = -4;
        int[] expected = new int[] { 0, -1, -3, -6, -10 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_1()
    {
        int input = 1;
        int[] expected = new int[] { 0, 1 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_0()
    {
        int input = 0;
        int[] expected = new int[] { 0 };

        int[] actual = SequenceSum.SumOfN(input);

        Assert.AreEqual(expected, actual);
    }
}