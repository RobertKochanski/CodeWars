using NUnit.Framework;

namespace Factional
{
    public class Tests
    {
        [Test]
        public void factionalTest()
        {
            Assert.AreEqual(1, Program.factorial(0));
            Assert.AreEqual(1, Program.factorial(1));
            Assert.AreEqual(2, Program.factorial(2));
            Assert.AreEqual(6, Program.factorial(3));
            Assert.AreEqual(24, Program.factorial(4));
            Assert.AreEqual(120, Program.factorial(5));
        }
    }
}