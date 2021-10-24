using AlgonDS._12Tree;
using AlgonDS._13TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAlgonDS._13TreeProblems
{
    [TestClass]
    public class MaxRootToLeafPathTests
    {
        private readonly MaxRootToLeafPath _sut;

        public MaxRootToLeafPathTests()
        {
            _sut = new MaxRootToLeafPath();
        }

        [TestMethod]
        public void ShouldReturnMaxLeafToPath()
        {
            var root = new TreeNode<int>(5);
            var b = new TreeNode<int>(11);
            var c = new TreeNode<int>(3);
            var d = new TreeNode<int>(4);
            var e = new TreeNode<int>(2);
            var f = new TreeNode<int>(1);

            root.Left = b;
            root.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;

            var result = _sut.GetMaxRootToLeafPath(root);

            Assert.AreEqual(20,result);
        }
    }
}
