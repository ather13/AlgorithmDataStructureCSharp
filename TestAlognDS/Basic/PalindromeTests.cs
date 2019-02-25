using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void PalindromeWord_FiveLetter()
        {
            var palindrome = new Palindrome();

            var actualResult = palindrome.IsWordPalindrome("MAdam");

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void PalindromeWord_FourLetter()
        {
            var palindrome = new Palindrome();

            var actualResult = palindrome.IsWordPalindrome("MAam");

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void PalindromeWord_SpecialChar()
        {
            var palindrome = new Palindrome();

            var actualResult = palindrome.IsWordPalindrome("!MAdam!");

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void NotPalindromeWord()
        {
            var palindrome = new Palindrome();

            var actualResult = palindrome.IsWordPalindrome("MAdam!");

            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void PalindromeWordNull()
        {
            var palindrome = new Palindrome();

            var actualResult = palindrome.IsWordPalindrome(null);

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void PalindromeWordEmpty()
        {
            var palindrome = new Palindrome();

            var actualResult = palindrome.IsWordPalindrome(string.Empty);

            Assert.IsTrue(actualResult);
        }
    }
}
