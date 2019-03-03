
using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlognDS
{
    [TestClass]
    public class NumberOfVowelsTests
    {
        [TestMethod]
        public void VowelsAreThere()
        {
            var actual = (new NumberOfVowels()).GetNumberOfVowels("hello world");
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NoVowels()
        {
            var actual = (new NumberOfVowels()).GetNumberOfVowels("lynch rhythm");
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
