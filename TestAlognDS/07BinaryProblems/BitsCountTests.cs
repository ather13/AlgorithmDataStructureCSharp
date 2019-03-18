using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class BitsCountTests
    {
        [TestMethod]
        public void BitsCountInGivenNumberTests()
        {
            var actual = new BitsCount().BitsCountInGivenNumber(6);

            Assert.AreEqual(9, actual);
        }
    }
}
