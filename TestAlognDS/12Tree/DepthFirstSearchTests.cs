using System.Collections.Generic;
using AlgonDS._12Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._12Tree
{
    [TestClass]
    public class DepthFirstSearchTests
    {
        private readonly DepthFirstSearchPreOrder _sut;


        public DepthFirstSearchTests()
        {
            _sut = new DepthFirstSearchPreOrder();
        }

        [TestMethod]
        public void ShouldReturnListWhileDfsTraverse()
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
            c.Right=f;

            //      a
            //     / \
            //    b    c
            //   / \    \
            //  d   e    f

            var expected = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f'
            };

            var result = _sut.DfsTraverse_PreOrder(root);

            CollectionAssert.AreEqual(expected,result);

        }

        [TestMethod]
        public void ShouldReturnListWhileDfsTraverseRecursively()
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
            c.Right = f;

            //      a
            //     / \
            //    b    c
            //   / \    \
            //  d   e    f

            var expected = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f'
            };

            var result = _sut.DfsTraverseRecursive_PreOrder(root);

            CollectionAssert.AreEqual(expected, result);

        }
    }
}
