using AlgonDS._12Tree;
using AlgonDS._13TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._13TreeProblems
{
    [TestClass]
    public class SearchNodeInTreeTests
    {
        private readonly SearchNodeInTree _sut;

        public SearchNodeInTreeTests()
        {
            _sut = new SearchNodeInTree();
        }

        [TestMethod]
        public void ShouldReturnTrueWhenDataFound()

        {
            var root = new TreeNode<char>('a');
            var b = new TreeNode<char>('b');
            var c = new TreeNode<char>('c');
            var d = new TreeNode<char>('d');
            var e = new TreeNode<char>('e');
            var f = new TreeNode<char>('f');

            root.Left = b;
            root.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;

            var result = _sut.FindNodeUsingBfs(root,'e');
            Assert.AreEqual(true,result);

            result = _sut.FindNodeUsingDfs(root, 'e');
            Assert.AreEqual(true, result);

            result = _sut.FindNodeUsingDfsRecursive(root, 'e');
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ShouldReturnFalseWhenNoDataFound()

        {
            var root = new TreeNode<char>('a');
            var b = new TreeNode<char>('b');
            var c = new TreeNode<char>('c');
            var d = new TreeNode<char>('d');
            var e = new TreeNode<char>('e');
            var f = new TreeNode<char>('f');

            root.Left = b;
            root.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;

            var result = _sut.FindNodeUsingBfs(root, 'x');
            Assert.AreEqual(false, result);

            result = _sut.FindNodeUsingDfs(root, 'x');
            Assert.AreEqual(false, result);

            result = _sut.FindNodeUsingDfsRecursive(root, 'x');
            Assert.AreEqual(false, result);
        }
    }
}
