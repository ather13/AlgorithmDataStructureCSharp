using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void VerifyVertices()
        {
            var actual = new Graph<int>();
            actual.AddVertex(1);
            actual.AddVertex(2);
            actual.AddVertex(3);

            Assert.IsTrue(actual.Neighbors.ContainsKey(1));
            Assert.IsTrue(actual.Neighbors.ContainsKey(2));
            Assert.IsTrue(actual.Neighbors.ContainsKey(3));
        }

        [TestMethod]
        public void VerifyEdges()
        {
            var actual = new Graph<int>();
            actual.AddVertex(1);
            actual.AddVertex(2);
            actual.AddEdges(1,2);

            Assert.IsTrue(actual.Neighbors[1].Contains(2));
            Assert.IsTrue(actual.Neighbors[2].Contains(1));
        }

        [TestMethod]
        public void VerifyVerticesNotExists()
        {
            var actual = new Graph<int>();
            actual.AddVertex(1);
            actual.AddVertex(2);
            actual.AddVertex(3);

            Assert.IsFalse(actual.Neighbors.ContainsKey(4));
        }

        [TestMethod]
        public void VerifyEdgesNotExsists()
        {
            var actual = new Graph<int>();
            actual.AddVertex(1);
            actual.AddVertex(2);
            actual.AddEdges(1, 2);
            actual.AddEdges(1, 4); //wrong value passed
            actual.AddEdges(2, 4); //wrong value passed

            Assert.IsFalse(actual.Neighbors[1].Contains(4));
            Assert.IsFalse(actual.Neighbors[2].Contains(4));
        }
    }
}
