using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class SumMergedOtherHalfTests
    {
        [TestMethod]
        public void VerifySumMergeOtherHalf()
        {
            var actual = new SumMergedOtherHalf();
            actual.Add(2);
            actual.Add(3);
            actual.Add(4);
            actual.Add(5);
            actual.Add(6);
            //actual.Add(7);

            actual.SumMergeOtherHalf();
            
            Assert.AreEqual(7, actual.GetData(0) + actual.GetData(4)); 
        }
    }
}
