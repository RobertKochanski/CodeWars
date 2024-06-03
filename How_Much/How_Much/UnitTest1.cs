using NUnit.Framework;

namespace How_Much
{
    public class Tests
    {
        [Test]
        public static void BasicTest()
        {
            Assert.AreEqual("[[M: 37 B: 5 C: 4][M: 100 B: 14 C: 11]]", Carboat.howmuch(1, 100));
            Assert.AreEqual("[[M: 1045 B: 149 C: 116]]", Carboat.howmuch(1000, 1100));
            Assert.AreEqual("[[M: 9991 B: 1427 C: 1110]]", Carboat.howmuch(10000, 9950));
            Assert.AreEqual("[[M: 37 B: 5 C: 4][M: 100 B: 14 C: 11][M: 163 B: 23 C: 18]]", Carboat.howmuch(0, 200));
            Assert.AreEqual("[]", Carboat.howmuch(2950, 2950));
        }
    }
}