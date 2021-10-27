using System.Data;
using AlgonDS._14DpMemoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._14DpMemoization
{
    [TestClass]
    public class HowSumProblemTests
    {
        private readonly HowSumProblem _sut;

        public HowSumProblemTests()
        {
            _sut = new HowSumProblem();
        }


        [TestMethod]
        public void ShouldReturnAnyArrayWhenCanSum()
        {
            var result = _sut.GetHowSum(7, new int[] { 6, 3, 4, 1, 5 });
            CollectionAssert.AreEqual(new int[] {1,6} , result);
        }

        [TestMethod]
        public void ShouldReturnNullWhenCantSum()
        {
            var result = _sut.GetHowSum(7, new int[] { 2,4 });
            Assert.AreEqual(null, result);
        }
    }
}
