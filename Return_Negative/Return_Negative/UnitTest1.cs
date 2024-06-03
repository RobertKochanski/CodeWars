using NUnit.Framework;

namespace Return_Negative
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, Kata.MakeNegative(42));
            Assert.AreEqual(0, Kata.MakeNegative(0));
            Assert.AreEqual(-10, Kata.MakeNegative(-10));
        }
    }
}