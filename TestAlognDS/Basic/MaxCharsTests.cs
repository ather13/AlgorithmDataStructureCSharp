using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class MaxCharsTests
    {
        [TestMethod]
        public void CheckMaxChars()
        {
            var expected = "l";

            var actual = (new MaxChars()).FindMaxChars("hello");

            Assert.AreEqual(expected, actual,true);
        }

        [TestMethod]
        public void CheckMaxCharsNull()
        {
            string expected = null;

            var actual = (new MaxChars()).FindMaxChars(null);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMaxCharsEmpty()
        {
            var expected = string.Empty;

            var actual = (new MaxChars()).FindMaxChars(string.Empty);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMaxCharsNumbers()
        {
            var expected = "1";

            var actual = (new MaxChars()).FindMaxChars("Madam 11123");

            Assert.AreEqual(expected, actual, true);
        }

        [TestMethod]
        public void CheckMaxCharsSameMax()
        {
            var expected = "a";

            var actual = (new MaxChars()).FindMaxChars("Madam");

            Assert.AreEqual(expected, actual,true);
        }

    }
}
