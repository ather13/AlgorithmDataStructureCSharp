using AlgonDS._11GraphProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._11GraphProblems
{
    [TestClass]
    public class MinIslandSizeTests
    {
        private readonly MinIslandSizeProblem _sut;

        public MinIslandSizeTests()
        {
            _sut = new MinIslandSizeProblem();
        }

        [TestMethod]
        public void GetMinIslandSize()
        {
            var grid = new char[6][]
            {
                new char[] {'W','L','W','W','W' },
                new char[] {'W','L','W','W','W' },
                new char[] {'W','W','W','L','W' },
                new char[] {'W','W','L','L','W' },
                new char[] {'L','W','W','L','L' },
                new char[] {'L','L','W','W','W' },
            };

            var count = _sut.GetMinIslandCount(grid);

            Assert.AreEqual(2, count);
        }
    }
}
