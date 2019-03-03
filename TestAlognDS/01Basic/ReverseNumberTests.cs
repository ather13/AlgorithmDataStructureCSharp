using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class ReverseNumberTests
    {
        [TestMethod]
        public void CheckReverseNumber()
        {
            var actualNumber = 123;
            var expectedNumber = 321;
            var reversedNumber = (new ReverseNumber()).ReverseMe(actualNumber);

            Assert.AreEqual(reversedNumber, expectedNumber);
        }

        [TestMethod]
        public void CheckReverseOneDigitNumber()
        {
            var actualNumber = 1;
            var reversedNumber = (new ReverseNumber()).ReverseMe(actualNumber);

            Assert.AreEqual(reversedNumber, actualNumber);
        }

        [TestMethod]
        public void CheckReverseNegativeNumber()
        {
            var actualNumber = -123;
            var expectedNumber = -321;
            var reversedNumber = (new ReverseNumber()).ReverseMe(actualNumber);

            Assert.AreEqual(reversedNumber, expectedNumber);
        }

        [TestMethod]
        public void CheckReverseNumberWithZeros()
        {
            var actualNumber = 100;
            var expectedNumber = 1;
            var reversedNumber = (new ReverseNumber()).ReverseMe(actualNumber);

            Assert.AreEqual(reversedNumber, expectedNumber);
        }
    }
}
