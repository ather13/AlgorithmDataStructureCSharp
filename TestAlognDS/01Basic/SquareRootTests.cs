using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class SquareRootTests
    {
        [TestMethod]
        public void SquareRootSuccess()
        {
            var actual = (new SquareRoot()).Getsquareroot(16);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void SquareRootFailure()
        {
            var actual = (new SquareRoot()).Getsquareroot(15);

            Assert.AreEqual(15, actual); //return same number if no square root found
        }
    }
}
