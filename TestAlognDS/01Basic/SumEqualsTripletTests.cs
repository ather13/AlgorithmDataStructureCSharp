using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class SumEqualsTripletTests
    {
        [TestMethod]
        public void SumEqualsTripletSuccess()
        {
            var actual = (new SumEqualsTriplet()).FindSum(new int[] { 12, 3, 4, 1, 6, 9 }, 24);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void FindSumWithSortedSuccess()
        {
            var actual = (new SumEqualsTriplet()).FindSumWithSorting(new int[] { 12, 3, 4, 1, 6, 9 }, 24);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SumEqualsTripletFailure()
        {
            var actual = (new SumEqualsTriplet()).FindSum(new int[] { 12, 3, 4, 1, 6, 9 }, 100);

            Assert.IsFalse(actual);
        }
    }
}
