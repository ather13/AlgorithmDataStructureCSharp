using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciSucess()
        {
            var actual = (new Fibonacci()).GetFibonacci2List(5);

            Assert.AreEqual(",0,1,1,2,3,5", actual);
        }
    }
}
