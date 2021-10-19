using AlgonDS._11GraphProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestAlgonDS._11GraphProblems
{
    public class ConnectedComponentCountsTests
    {
        public readonly ConnectedComponentCounts _sut;

        public ConnectedComponentCountsTests()
        {
            _sut = new ConnectedComponentCounts();
        }

        public void ShouldReturnComponentsCount()
        {
            var graph = new Dictionary<int, int[]>()
            {
                { 0, new int[] { 8, 1, 5 } },
                { 1, new int[] { 0 } },
                { 5, new int[] { 0, 8 } },
                { 8, new int[] { 0, 5 } },
                { 2, new int[] { 3, 4 } },
                { 3, new int[] { 2, 4 } },
                { 4, new int[] { 3, 2 } }
            };

            var count = _sut.GetConnectedComponentCounts(graph);

            Assert.AreEqual(3, count);
        }
    }
}
