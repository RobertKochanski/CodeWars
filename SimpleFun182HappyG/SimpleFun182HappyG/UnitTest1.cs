namespace myjinxin
{
    using NUnit.Framework;

    public class TestsSuite
    {
        private Kata kata = new Kata();

        private void DoTest(bool expected, string input)
        {
            bool actual = kata.HappyG(input);
            Assert.AreEqual(expected, actual, "for input: \"" + input + "\"");
        }

        [Test]
        public void SampleTests()
        {
            DoTest(true, "gg0gg3gg0gg");
            DoTest(false, "gog");
            DoTest(false, "ggg ggg g ggg");
            DoTest(true, "A half of a half is a quarter.");
            DoTest(false, "good grief");
            DoTest(true, "bigger is ggooder");
            DoTest(true, "gggggggggg");
        }
    }

}