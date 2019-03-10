using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class AddTwoBinaryTests
    {
        [TestMethod]
        public void CalculateSuccess()
        {
            var actual = (new AddTwoBinary()).Calculate("00001", "00010");

            Assert.AreEqual("00011", actual);
        }


        [TestMethod]
        public void Calculate2Success()
        {
            var actual = (new AddTwoBinary()).Calculate("01001", "01010");

            Assert.AreEqual("10011", actual);
        }

    }
}
