using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class CapitalizeWordTests
    {
        [TestMethod]
        public void CheckSimpleSentence()
        {
            var expected = "Hello World";
            var actual = (new CapitalizeWord()).CapitalizeMe("hello world");

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void CheckJumbledSentence()
        {
            var expected = "Hello World";
            var actual = (new CapitalizeWord()).CapitalizeMe("hEllO woRld");

            Assert.AreEqual(expected, actual, false);
        }

        [TestMethod]
        public void ChecklongSentence()
        {
            var expected = "I Love This Whole World And Want Peace";
            var actual = (new CapitalizeWord()).CapitalizeMe("i LOVE thIs wHolE world anD want peAce");

            Assert.AreEqual(expected, actual, false);
        }

        //This test case works differently with TextInfo.ToTitleCase
        [TestMethod]
        public void CheckSentenceMultipleSpaceSpecialChars()
        {
            var expected = "Hello   This Wornderful $World !!";
            var actual = (new CapitalizeWord()).CapitalizeMe("Hello   this wornderful $World !!");

            Assert.AreEqual(expected, actual, false);
        }
    }
}
