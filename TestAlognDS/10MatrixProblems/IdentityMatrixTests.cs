using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS
{
    [TestClass]
    public class IdentityMatrixTests
    {
        [TestMethod]
        public void Verify2X2Matrix_Success()
        {
            var matrix = new int[,] { { 1, 0 },{ 0, 1 } };

            var actual = new IdentityMatrix().IsIdentityMatrix(matrix);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Verify3X3Matrix_Success()
        {
            var matrix = new int[,] { { 1, 0,0 }, { 0, 1,0 }, { 0, 0, 1 } };

            var actual = new IdentityMatrix().IsIdentityMatrix(matrix);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Verify2X2Matrix_AllOnes_Failure()
        {
            var matrix = new int[,] { { 1, 1 }, { 1, 1 } };

            var actual = new IdentityMatrix().IsIdentityMatrix(matrix);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Verify2X2Matrix_Reverse_Failure()
        {
            var matrix = new int[,] { { 0, 1 }, { 1, 0 } };

            var actual = new IdentityMatrix().IsIdentityMatrix(matrix);

            Assert.AreEqual(false, actual);
        }
    }
}
