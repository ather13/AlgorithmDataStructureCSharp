using System.Collections.Generic;
using AlgonDS._12Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._12Tree
{
    [TestClass]
    public class BreadthFirstSearchTests
    {
        private readonly BreadthFirstSearch _sut;

        public BreadthFirstSearchTests()
        {
            _sut = new BreadthFirstSearch();
        }

        [TestMethod]
        public void ReturnValueUsingBfsSearch()
        {
            var root = new TreeNode<char>('a');
            var b = new TreeNode<char>('b');
            var c = new TreeNode<char>('c');
            var d = new TreeNode<char>('d');
            var e = new TreeNode<char>('e');
            var f = new TreeNode<char>('f');

            root.Left = b;
            root.Right = c;
            b.Right = e;
            b.Left = d;
            c.Right = f;

            //      a
            //     / \
            //    b    c
            //   / \    \
            //  d   e    f

            var expected = new List<char>()
            {
                'a', 'b','c','d','e','f'
            };

            var result = _sut.BfsTraverse(root);

            CollectionAssert.AreEqual(expected,result);
        }
    }
}
