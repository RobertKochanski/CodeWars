namespace Find_the_index_of_the_second
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(3, Kata.SecondSymbol("Hello world!!", 'l'), "Find the index of the second symbol \"l\" in the string");
            Assert.AreEqual(7, Kata.SecondSymbol("Hello world!!", 'o'), "Find the index of the second symbol \"o\" in the string");
            Assert.AreEqual(-1, Kata.SecondSymbol("Hello world!!", 'A'), "The symbol \"A\" is not in the string");
            Assert.AreEqual(-1, Kata.SecondSymbol("", 'q'), "The symbol \"q\" is not in the string");
            Assert.AreEqual(-1, Kata.SecondSymbol("Hello", '!'), "The symbol \"!\" is not in the string");
        }
    }

}