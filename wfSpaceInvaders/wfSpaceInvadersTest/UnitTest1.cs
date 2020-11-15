using NUnit.Framework;

namespace wfSpaceInvadersTest
{
    [TestFixture]
    public class Tests
    {

        int a;
        int b;
        [SetUp]
        public void Setup()
        {
            a = 16;
            b = 4;
        }

        [Test]
        public void CheckSum()
        {
            Assert.AreEqual(20, a + b);
        }

        [Test]
        public void CheckDifference()
        {
            Assert.AreEqual(12, a - b);
        }

        [Test]
        public void CheckMultiplication()
        {
            Assert.AreEqual(64, a * b);
        }


        [Test]
        public void CheckDivision()
        {
            Assert.AreEqual(4, a / b);
        }



    }
}