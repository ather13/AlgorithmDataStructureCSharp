
using AlgonDS._12Tree;
using AlgonDS._13TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._13TreeProblems
{
    [TestClass]
    public class TreeSumProblemTests
    {
        private readonly TreeSumProblem _sut;

        public TreeSumProblemTests()
        {
            _sut = new TreeSumProblem();
        }

        [TestMethod]
        public void ShouldReturnSumWhenTreeParamIsPassed()
        {
            var root = new TreeNode<int>(3);
            var b = new TreeNode<int>(11);
            var c = new TreeNode<int>(4);
            var d = new TreeNode<int>(4);
            var e = new TreeNode<int>(2);
            var f = new TreeNode<int>(1);

            root.Left = b;
            root.Right = c;
            b.Right = e;
            b.Left = d;
            c.Right = f;

            var result = _sut.SumNodesDfs(root);
            Assert.AreEqual(25,result);

            result = _sut.SumNodesDfsRecursive(root);
            Assert.AreEqual(25, result);

            result = _sut.SumNodeBfs(root);
            Assert.AreEqual(25, result);
        }
    }
}
