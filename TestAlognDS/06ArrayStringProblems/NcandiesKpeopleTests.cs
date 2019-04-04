using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class NcandiesKpeopleTests
    {
        [TestMethod]
        public void Verify07K03N()
        {
            var actual = new NcandiesKpeople().GetCandies(7, 3);
            var expecte =new int[] { 2, 2, 3 };
            CollectionAssert.AreEqual(expecte, actual);
        }

        [TestMethod]
        public void Verify10K03N()
        {
            var actual = new NcandiesKpeople().GetCandies(10, 3);
            var expecte = new int[] { 2, 4, 4 };
            CollectionAssert.AreEqual(expecte, actual);
        }

        [TestMethod]
        public void Verify07K04N()
        {
            var actual = new NcandiesKpeople().GetCandies(7, 4);
            var expecte = new int[] { 1, 2, 3,1 };
            CollectionAssert.AreEqual(expecte, actual);
        }
    }
}
