namespace Solution
{
    using Is_it_a_letter;
    using NUnit.Framework;
    using System;

    // TODO: Replace examples and use TDD by writing your own tests

    [TestFixture]
    public class SolutionTest
    {
        [TestCase('a', ExpectedResult = true)]
        [TestCase('1', ExpectedResult = false)]
        [TestCase('@', ExpectedResult = false)]
        public bool Sample_Cases(char c) => Kata.IsItLetter(c);
    }
}

