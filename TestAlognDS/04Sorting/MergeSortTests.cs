using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestAlgonDS
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void Sort10Numbers()
        {
            var expected = new List<int> { 1, 5, 9, 12, 24, 36, 72,100 };
            var actual = (new MergeSort()).GetSortedList(new List<int> { 1, 72, 9, 12, 36, 24, 5,100 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
