using NUnit.Framework;

namespace Hex_to_Decimal
{
    public class Tests
    {
        [Test]
        public void BasicTests()
        {
            //Assert.AreEqual(1, Kata.HexToDec("1"));
            //Assert.AreEqual(10, Kata.HexToDec("a"));
            //Assert.AreEqual(16, Kata.HexToDec("10"));
            //Assert.AreEqual(255, Kata.HexToDec("FF"));
            Assert.AreEqual(-12, Kata.HexToDec("-C"));
        }
    }
}