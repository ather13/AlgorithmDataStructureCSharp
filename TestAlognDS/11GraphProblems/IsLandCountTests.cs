using AlgonDS._11GraphProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._11GraphProblems
{
    [TestClass]
    public class IsLandCountTests
    {
        private readonly IsLandCountProblem _sut;

        public IsLandCountTests()
        {
            _sut = new IsLandCountProblem();
        }

        [TestMethod]
        public void ShouldReturnIslandCount()
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

            var count = _sut.GetIslandCount(grid);

            Assert.AreEqual(3,count);
        }
    }
}
