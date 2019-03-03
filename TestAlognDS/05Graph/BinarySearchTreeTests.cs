using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{    
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void VerifyInsertSearch()
        {
            var actual = new BinarySearchTree();
            actual.Insert(4);
            actual.Insert(3);
            actual.Insert(1);
            actual.Insert(2);
            actual.Insert(5);
            actual.Insert(6);

            Assert.IsTrue(actual.Search(1));
            Assert.IsTrue(actual.Search(2));
            Assert.IsTrue(actual.Search(3));
            Assert.IsTrue(actual.Search(4));
            Assert.IsTrue(actual.Search(5));
            Assert.IsTrue(actual.Search(6));
        }
       
        [TestMethod]
        public void VerifySearchNotExsists()
        {
            var actual = new BinarySearchTree();
            actual.Insert(4);
            actual.Insert(3);
            actual.Insert(1);
            actual.Insert(2);
            actual.Insert(5);
            actual.Insert(6);

            Assert.IsFalse(actual.Search(445));
        }
    }
}
