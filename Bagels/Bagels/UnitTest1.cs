using Bagels;
using NUnit.Framework;
using System;
using System.Reflection.Emit;


namespace Solution
{    
    [TestFixture]
    public class BagelTest
    {
        [Test]
        public void TestBagel()
        {
            Bagel bagel = BagelSolver.Bagel;
            Assert.That(bagel.Value, Is.EqualTo(4));
        }
    }
}