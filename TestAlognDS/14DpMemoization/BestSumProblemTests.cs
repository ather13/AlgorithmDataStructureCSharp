using AlgonDS._14DpMemoization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._14DpMemoization
{
    [TestClass]
    public class BestSumProblemTests
    {
        private readonly BestSumProblem _sut;

        public BestSumProblemTests()
        {
            _sut = new BestSumProblem();
        }


        [TestMethod]
        public void ShouldReturnBestSumWhenExists()
        {
            var result = _sut.GetBestSumMemo(7, new int[] { 5, 3, 4, 7 });
            CollectionAssert.AreEqual(new int[] { 7 }, result);
        }
    }
}
