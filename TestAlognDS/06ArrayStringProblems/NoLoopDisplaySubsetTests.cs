using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class NoLoopDisplaySubsetTests
    {
        [TestMethod]
        public void PrintSubsetTests()
        {
            var actual = new NoLoopDisplaySubset().PrintAll(4);

            var expected = "{  1  2  3  4 }\n{  1  2  3 }\n{  1  2 }\n{  1 }";

            Assert.AreEqual(expected, actual);
        }
    }
}
