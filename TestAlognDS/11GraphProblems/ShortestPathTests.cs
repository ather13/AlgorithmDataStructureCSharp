using AlgonDS._11GraphProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._11GraphProblems
{
    [TestClass]
    public class ShortestPathTests
    {
        private readonly ShortestPath _sut;

        public ShortestPathTests()
        {
            _sut = new ShortestPath();
        }

        [TestMethod]
        public void ReturnDistanceWhenPathFound()
        {
            var graph = new char[5][]
            {
                new char[] {'w','x'},
                new char[] {'x','y'},
                new char[] {'z','y'},
                new char[] {'z','v'},
                new char[] {'w','v'},
            };

            var convertedGraph = new Helper().Convert(graph);

            var count = _sut.GetShortestPath(convertedGraph, 'w', 'z');

            Assert.AreEqual(2,count);
        }

        [TestMethod]
        public void ReturnNegativeOneWhenPathNotFound()
        {
            var graph = new char[5][]
            {
                new char[] {'w','x'},
                new char[] {'x','y'},
                new char[] {'z','y'},
                new char[] {'z','v'},
                new char[] {'w','v'},
            };

            var convertedGraph = new Helper().Convert(graph);

            var count = _sut.GetShortestPath(convertedGraph, 'w', 'a');

            Assert.AreEqual(-1, count);
        }
    }
}
