namespace IPv4_to_int32
{

    [TestFixture]
    public class IPConverterTest
    {
        [Test]
        public void TestIPtoInt()
        {
            Assert.AreEqual(2149583361, IPConvert.ToInt32("128.32.10.1"), "Incorrect answer for ip = \"128.32.10.1\"");
        }
    }
}