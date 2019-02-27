using AlgonDS;
using AlognDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void Sort8Numbers()
        {
            var expected = new List<int> { 2,5,12,19,22,23, 50,60, 76,100};
            var unsorted = new List<int> { 60, 12, 2, 50, 76, 23, 5, 19,22,100 };
            (new QuickSort()).GetSortedList(unsorted,0,unsorted.Count-1);

            CollectionAssert.AreEqual(expected, unsorted);
        }
    }
}
