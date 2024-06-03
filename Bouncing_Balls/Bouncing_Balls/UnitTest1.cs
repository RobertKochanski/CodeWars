using NUnit.Framework;

namespace Bouncing_Balls
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, BouncingBall.bouncingBall(3.0, 0.66, 1.5));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(15, BouncingBall.bouncingBall(30.0, 0.66, 1.5));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(599146449, BouncingBall.bouncingBall(30.0, 0.99999999, 1.5));
        }
    }
}