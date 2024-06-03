using NUnit.Framework;

namespace Reverse
{
    public class Tests
    {
        [Test]
        public void SplitTests()
        {
            var testString = "This is a test";
            var result = Kata.Split(testString, ' ');

            Assert.AreEqual("test", result[3]);
            Assert.AreEqual("a", result[2]);
            Assert.AreEqual("is", result[1]);
            Assert.AreEqual("This", result[0]);
        }

        [Test]
        public void ReverseTests()
        {
            var testString = "This is a test";
            var testSplitedString = Kata.Split(testString, ' ');
            var result = Kata.Reverse(testSplitedString);

            Assert.AreEqual(testSplitedString[3], result[0]);
            Assert.AreEqual(testSplitedString[2], result[1]);
            Assert.AreEqual(testSplitedString[1], result[2]);
            Assert.AreEqual(testSplitedString[0], result[3]);
        }

        [Test]
        public void JoinTests()
        {
            var testString = "This is a test";
            var testSplitedString = Kata.Split(testString, ' ');
            var testReverse = Kata.Reverse(testSplitedString);
            var result = Kata.Join(testReverse, ' ');

            Assert.AreEqual("test a is This", result);
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
        }
    }
}