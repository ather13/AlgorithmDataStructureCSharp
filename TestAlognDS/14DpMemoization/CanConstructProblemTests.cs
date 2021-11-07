using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgonDS._14DpMemoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._14DpMemoization
{
    [TestClass]
    public class CanConstructProblemTests
    {
        private readonly CanConstructProblem _sut;

        public CanConstructProblemTests()
        {
            _sut = new CanConstructProblem();
        }

        [TestMethod]
        public void ShouldReturnTrueIfItConstructTarget()
        {
            var result= _sut.CanConstructiveRecursive("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" });
            Assert.AreEqual(true,result);

            result = _sut.CanConstructiveRecursiveMemo("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" });
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ShouldReturnFalseIfCantConstructTarget()
        {
            var result = _sut.CanConstructiveRecursive("skateboard", new string[] { "bo", "rd", "ate", "t", "ska","sk","boar" });
            Assert.AreEqual(false, result);

            result = _sut.CanConstructiveRecursiveMemo("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
            Assert.AreEqual(false, result);
        }
    }
}
