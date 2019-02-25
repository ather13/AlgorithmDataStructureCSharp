using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlognDS
{
    [TestClass]
    public class ReverseStringTests
    {
        [TestMethod]
        public void CheckHello()
        {
            var toBeReversed = "Hello";
            var reversed = "olleH";
            ReverseString reverseString = new ReverseString();
            var actualResult = reverseString.ReverseMe(toBeReversed);

            Assert.AreEqual(actualResult, reversed);
        }

        [TestMethod]
        public void CheckNull()
        {
            string toBeReversed = null;
            string reversed = null;
            ReverseString reverseString = new ReverseString();
            var actualResult = reverseString.ReverseMe(toBeReversed);

            Assert.AreEqual(actualResult, reversed);
        }

        [TestMethod]
        public void CheckEmpty()
        {
            string toBeReversed = string.Empty;
            string reversed = string.Empty;
            ReverseString reverseString = new ReverseString();
            var actualResult = reverseString.ReverseMe(toBeReversed);

            Assert.AreEqual(actualResult, reversed);
        }

        [TestMethod]
        public void CheckSententce()
        {
            string toBeReversed = "I am in your world!!";
            string reversed = "!!dlrow ruoy ni ma I";
            ReverseString reverseString = new ReverseString();
            var actualResult = reverseString.ReverseMe(toBeReversed);

            Assert.AreEqual(actualResult, reversed);
        }

    }
}
