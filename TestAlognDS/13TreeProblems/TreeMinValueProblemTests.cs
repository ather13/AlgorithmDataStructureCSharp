using AlgonDS._12Tree;
using AlgonDS._13TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._13TreeProblems
{
    [TestClass]
    public class TreeMinValueProblemTests
    {
        private readonly TreeMinValueProblem _sut;

        public TreeMinValueProblemTests()
        {
            _sut = new TreeMinValueProblem();
        }

        [TestMethod]
        public void ShouldReturnMinValueFromTree()
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

            var result = _sut.GetMinValueDfs(root);
            Assert.AreEqual(1, result);

            result = _sut.GetMinValueDfsRecursive(root);
            Assert.AreEqual(1, result);

            result = _sut.GetMinValueBfs(root);
            Assert.AreEqual(1, result);
        }
    }
}
