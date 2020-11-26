using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace wfSpaceInvadersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSum()
        {
            int a =10; 
            int b=24;
            Assert.AreEqual(3, a + b);           
        }

        [TestMethod]
        public void CheckDivision()
        {
            int a = 10;
            int b = 30;
            Assert.AreEqual(3, b/a);
        }

        [TestMethod]
        public void CheckMultiplication()
        {
            int a = 10;
            int b = 24;
            Assert.AreEqual(240, a*b);
        }


        [TestMethod]
        public void CheckDifference()
        {
            int a = 10;
            int b = 24;
            Assert.AreEqual(14, b-a);
        }

    }
}
