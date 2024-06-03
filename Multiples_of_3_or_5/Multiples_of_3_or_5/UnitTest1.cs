using NUnit.Framework;

namespace Multiples_of_3_or_5
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Solution(10));
        }
    }
}