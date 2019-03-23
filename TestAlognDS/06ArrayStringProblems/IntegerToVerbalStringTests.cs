using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class IntegerToVerbalStringTests
    {
        [TestMethod]
        public void VerifySingleDigit()
        {
            var actual = new IntegerToVerbalString().ToWord(4);

            Assert.AreEqual("four", actual);
        }

        [TestMethod]
        public void VerifyDoubleDigit()
        {
            var actual = new IntegerToVerbalString().ToWord(44);

            Assert.AreEqual("forty four", actual);
        }

        [TestMethod]
        public void VerifyDoubleDigitLessThanTwenty()
        {
            var actual = new IntegerToVerbalString().ToWord(17);

            Assert.AreEqual("seventeen", actual);
        }

        [TestMethod]
        public void VerifyTrippleDigit()
        {
            var actual = new IntegerToVerbalString().ToWord(768);

            Assert.AreEqual("seven hundred sixty eight", actual);
        }
    }
}
