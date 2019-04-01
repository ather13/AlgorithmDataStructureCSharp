using AlgonDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgonDS
{
    [TestClass]
    public class BreadthFirstSearchTests
    {
        [TestMethod]
        public void Search()
        {
            var graph = new Graph<int>();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdges(1, 2);

            var actual = (new BreadthFirstSearch()).Search(graph, 1, 2);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SearchRoot()
        {
            var graph = new Graph<int>();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdges(1, 2);

            var actual = (new BreadthFirstSearch()).Search(graph, 1, 1);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SearchNotExsists()
        {
            var graph = new Graph<int>();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdges(1, 2);

            var actual = (new BreadthFirstSearch()).Search(graph, 1, 4);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SearchRootNotExsists()
        {
            var graph = new Graph<int>();
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdges(1, 2);

            var actual = (new BreadthFirstSearch()).Search(graph, 4, 2);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void LargeSearch()
        {
            var graph = new Graph<int>();
            graph.AddVertex(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            graph.AddEdges(new List<Tuple<int, int>>(){
            new Tuple<int,int>(1,2),new Tuple<int,int>(1,3),new Tuple<int,int>(2,4)
            ,new Tuple<int,int>(4,7),new Tuple<int,int>(7,5),new Tuple<int,int>(3,6)
            ,new Tuple<int,int>(5,3),new Tuple<int,int>(5,6),new Tuple<int,int>(5,8)
            ,new Tuple<int,int>(8,9),new Tuple<int,int>(8,10),new Tuple<int,int>(9,10)
        });

            var dfs = new BreadthFirstSearch();
            var result = dfs.Search(graph, 1, 7);

            Assert.IsTrue(result);
        }
    }
}
