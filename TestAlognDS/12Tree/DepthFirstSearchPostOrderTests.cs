using System.Collections.Generic;
using AlgonDS._12Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._12Tree
{
    [TestClass]
    public class DepthFirstSearchPostOrderTests
    {
        private readonly DepthFirstSearchPostOrder _sut;
        private readonly TreeNode<char> _root;
        private readonly List<char> _postOrderList;

        public DepthFirstSearchPostOrderTests()
        {
            _sut = new DepthFirstSearchPostOrder();

            _root = new TreeNode<char>('a');
            var b = new TreeNode<char>('b');
            var c = new TreeNode<char>('c');
            var d = new TreeNode<char>('d');
            var e = new TreeNode<char>('e');
            var f = new TreeNode<char>('f');

            _root.Left = b;
            _root.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            //      a
            //     / \
            //    b    c
            //   / \    \
            //  d   e    f

            _postOrderList = new List<char>()
            {
                'd', 'e', 'b', 'f', 'c', 'a'
            };
        }

        [TestMethod]
        public void ShouldReturnListOfPostOrder()
        {
            //var result = _sut.TraverseRecursive(_root);
            //CollectionAssert.AreEqual(_postOrderList,result);
            var result = _sut.TraverseIterative(_root);
            CollectionAssert.AreEqual(_postOrderList,result);
        }
    }
}
