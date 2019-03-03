using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlognDS
{
    [TestClass]
    public class ChunkOfArrayTests
    {
        [TestMethod]
        public void SizeSplitArrayInEqualSize()
        {
            int[] toBeChunked = new int[] { 1, 2, 3, 4,5,6,7,8 };
            var expected = new List<int[]>()
            {
                new int[] { 1, 2},
            new int[] { 3, 4 },
            new int[] { 5, 6 },
            new int[] { 7, 8 }
            };

            var actual = (new ChunkOfArray()).GetChunkOfArrays(toBeChunked, 2);

            CollectionAssert.AreEqual(expected, actual,new IntArrayComparer());
        }

        [TestMethod]
        public void SizeIsLargerThanArray()
        {
            int[] toBeChunked = new int[] { 1, 2, 3 };
            var expected = new List<int[]>()
            {
                new int[] { 1, 2,3}
            };

            var actual = (new ChunkOfArray()).GetChunkOfArrays(toBeChunked, 4);

            CollectionAssert.AreEqual(expected, actual, new IntArrayComparer());
        }

        [TestMethod]
        public void SizeDONTSplitArrayInEqualSize()
        {
            int[] toBeChunked = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var expected = new List<int[]>()
            {
                new int[] { 1, 2,3},
            new int[] { 4,5, 6 },
            new int[] { 7, 8 }
            };

            var actual = (new ChunkOfArray()).GetChunkOfArrays(toBeChunked, 3);

            CollectionAssert.AreEqual(expected, actual, new IntArrayComparer());
        }

    }

    class IntArrayComparer : Comparer<int[]>
    {
        public override int Compare(int[] x, int[] y)
        {
            // compare the two mountains
            // for the purpose of this tests they are considered equal when their identifiers (names) match
            //return x.Name.CompareTo(y.Name);
            if (x.Length != y.Length) return 1; //not equal

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i]) return 1; //not equal
            }

            return 0; //equal
        }
    }
}
