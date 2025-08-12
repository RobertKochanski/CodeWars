namespace myjinxin
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Myjinxin
    {

        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            var matrix = new int[][]{
            new int[]{1,2,3},
            new int[]{4,5,6},
            new int[]{7,8,9}};

            var expected = new int[][]{
            new int[]{9,2,7},
            new int[]{4,5,6},
            new int[]{3,8,1}};
            Assert.That(kata.ReverseOnDiagonals(matrix), Is.EqualTo(expected));


            matrix = new int[][]{
            new int[]{239}};

            expected = new int[][]{
            new int[]{239}};
            Assert.That(kata.ReverseOnDiagonals(matrix), Is.EqualTo(expected));


            matrix = new int[][]{
            new int[]{1,10},
            new int[]{100,1000}};

            expected = new int[][]{
            new int[]{1000,100},
            new int[]{10,1}};
            Assert.That(kata.ReverseOnDiagonals(matrix), Is.EqualTo(expected));


            matrix = new int[][]{
            new int[]{43,455,32,103},
            new int[]{102,988,298,981},
            new int[]{309,21,53,64},
            new int[]{2,22,35,291}};

            expected = new int[][]{
            new int[]{291,455,32,2},
            new int[]{102,53,21,981},
            new int[]{309,298,988,64},
            new int[]{103,22,35,43}};
            Assert.That(kata.ReverseOnDiagonals(matrix), Is.EqualTo(expected));


        }

    }
}