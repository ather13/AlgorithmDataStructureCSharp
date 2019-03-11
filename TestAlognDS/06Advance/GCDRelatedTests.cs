using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class GCDRelatedTests
    {
        [TestMethod]
        public void GCDTwoNumbersSuccess()
        {
            var actual = (new GCDRelated()).GCDTwoNumbes(10,15);

            //10=5X2
            //15=5X3            
            Assert.AreEqual(5, actual); 
        }

        [TestMethod]
        public void GCDTwoNumbersFailure()
        {
            var actual = (new GCDRelated()).GCDTwoNumbes(2, 3);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void GCDMoreThan2NumbersSuccess()
        {
            var actual = (new GCDRelated()).GCDMoreThan2Numbers(new int[]{ 2,4,6,8,10});

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void GCDMoreThan2NumberssFailure()
        {
            var actual = (new GCDRelated()).GCDMoreThan2Numbers(new int[] { 2, 3, 4, 5, 6 });

            Assert.AreEqual(1, actual);
        }
    }
}
