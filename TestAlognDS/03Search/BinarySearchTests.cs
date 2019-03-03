using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void Search23From9ElemnetsPresentLeftOfMid()
        {
            var list = new List<int>() { 2, 4, 6, 8, 23, 32, 56, 70 };
            var param = 8;

            var actual = (new BinarySearch()).GetPositionOfItem(list, param,0,list.Count-1);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Search23From9ElemnetsPresentRightOfMid()
        {
            var list = new List<int>() { 2, 4, 6, 8, 23, 32, 56, 70 };
            var param = 32;

            var actual = (new BinarySearch()).GetPositionOfItem(list, param, 0, list.Count - 1);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Search23From9ElemnetsNOTPresnt()
        {
            var list = new List<int>() { 2, 4, 6, 8, 23, 32, 56, 70 };
            var param = 16;

            var actual = (new BinarySearch()).GetPositionOfItem(list, param,0,list.Count-1);

            Assert.AreEqual(-1, actual);
        }
    }
}
