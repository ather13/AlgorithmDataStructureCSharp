using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void  NormalTwoWords()
        {
            var actual = (new Anagram()).IsWordsAnagram("lives", "elvis");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void NormalTwoWordsProperCase()
        {
            var actual = (new Anagram()).IsWordsAnagram("Dog", "God");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TwoWordsCapitalSpecialChars()
        {
            var actual = (new Anagram()).IsWordsAnagram("Jim Morrison", "Mr. Mojo Risin");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TwoWordsNotAnagram()
        {
            var actual = (new Anagram()).IsWordsAnagram("are", "area");

            Assert.IsFalse(actual);
        }

    }
}
