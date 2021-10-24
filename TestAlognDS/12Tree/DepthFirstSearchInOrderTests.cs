using System.Collections.Generic;
using AlgonDS._12Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._12Tree
{
    [TestClass]
    public class DepthFirstSearchInOrderTests
    {
        private readonly DepthFirstSearchInOrder _sut;
        private readonly TreeNode<char> _root;
        private readonly List<char> _inOrderList;

        public DepthFirstSearchInOrderTests()
        {
            _sut = new DepthFirstSearchInOrder();

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

            _inOrderList = new List<char>()
            {
                 'd', 'b', 'e','a', 'c', 'f'
            };
        }

        [TestMethod]
        public void ShouldReturnDataInDfsInOrder()
        {
            var result = _sut.TraverseRecursively(_root);
            CollectionAssert.AreEqual(_inOrderList, result);

            result = _sut.TraverseIterative(_root);
            CollectionAssert.AreEqual(_inOrderList,result);
        }

    }
}
