using AlgonDS._14DpMemoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._14DpMemoization
{
    [TestClass]
    public class CanSumProblemTests
    {
        private readonly CanSumProblem _sut;

        public CanSumProblemTests()
        {
            _sut = new CanSumProblem();
        }

        [TestMethod]
        public void ShouldReturnTrueIfNumbersSum()
        {
            var result = _sut.CanSumIterative(7, new int[] { 6, 3, 4, 1, 5 });
            Assert.AreEqual(true,result);

            result = _sut.CanSumRecursive(7, new int[] { 6, 3, 4, 1, 5 });
            Assert.AreEqual(true, result);

            result = _sut.CanSumRecursiveMemo(7, new int[] { 6, 3, 4, 1, 5 });
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void ShouldReturnFalseIfNumbersDoesNotSum()
        {
            var result = _sut.CanSumIterative(7, new int[] { 2, 4 });
            Assert.AreEqual(false, result);

            result = _sut.CanSumRecursive(7, new int[] { 2, 4 });
            Assert.AreEqual(false, result);

            result = _sut.CanSumRecursiveMemo(7, new int[] { 2, 4 });
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShouldReturnFalseIfNumbersDoesNotSum_LargeSum()
        {
            var result = false;

            //result = _sut.CanSumIterative(101, new int[] { 2, 4 });
            //Assert.AreEqual(false, result);

            //result = _sut.CanSumRecursive(101, new int[] { 2, 4 });
            //Assert.AreEqual(false, result);

            result = _sut.CanSumRecursiveMemo(101, new int[] { 2, 4 });
            Assert.AreEqual(false, result);
        }
    }
}
