using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Squeaky_Window;

[TestFixture]
public class SlidingTest
{
    private static void DoTest(int[] expected, int[] nums, int k)
    {
        String message = "for k = " + k + " and nums = {" + String.Join(", ", nums) + "}\n";
        int[] actual = Kata.Sliding(nums, k);
        Assert.AreEqual(expected, actual, message);
    }

    [Test(Description = "Sample Tests")]
    public void Test1()
    {
        DoTest(new[] { 3, 3, 5, 5, 6, 7 }, new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
        DoTest(new[] { 7, 7, 7, 7, 7 }, new[] { -7, -8, 7, 5, 7, 1, 6, 0 }, 4);
        DoTest(new[] { 7, 4 }, new[] { 7, 2, 4 }, 2);
        DoTest(new[] { 11 }, new[] { 9, 11 }, 2);
        DoTest(new[] { 9, 11, 12 }, new[] { 9, 11, 12 }, 1);
        DoTest(new[] { -1 }, new[] { -1, -2, -3 }, 3);
        DoTest(new[] { -1, -2, -3 }, new[] { -1, -2, -3 }, 1);
        DoTest(new int[0], new[] { -1, -2, -3 }, 5);
    }
}