using System.Collections.Generic;
using AlgonDS._12Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._12Tree
{
    [TestClass]
    public class DepthFirstSearchPreOrderTests
    {
        private readonly DepthFirstSearchPreOrder _sut;
        private readonly TreeNode<char> _root;
        private readonly List<char> _preOrderList;
        
        public DepthFirstSearchPreOrderTests()
        {
            _sut = new DepthFirstSearchPreOrder();

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

            _preOrderList = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f'
            };
        }

        [TestMethod]
        public void ShouldReturnListWhileDfsTraverse()
        {
            var result = _sut.DfsTraverse_PreOrder(_root);

            CollectionAssert.AreEqual(_preOrderList,result);
        }

        [TestMethod]
        public void ShouldReturnListWhileDfsTraverseRecursively()
        {
            var result = _sut.DfsTraverseRecursive_PreOrder(_root);

            CollectionAssert.AreEqual(_preOrderList, result);
        }
    }
}
