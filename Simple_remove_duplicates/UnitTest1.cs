using NUnit.Framework;
using Simple_remove_duplicates;
using System;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual(new int[] { 4, 6, 3 }, Solution.solve(new int[] { 3, 4, 4, 3, 6, 3 }));
        Assert.AreEqual(new int[] { 1, 2, 3 }, Solution.solve(new int[] { 1, 2, 1, 2, 1, 2, 3 }));
        Assert.AreEqual(new int[] { 1, 2, 3, 4 }, Solution.solve(new int[] { 1, 2, 3, 4 }));
        Assert.AreEqual(new int[] { 4, 5, 2, 1 }, Solution.solve(new int[] { 1, 1, 4, 5, 1, 2, 1 }));
    }
}