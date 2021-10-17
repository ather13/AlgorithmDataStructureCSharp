using AlgonDS._11GraphProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestAlgonDS._11GraphProblems
{
    [TestCategory("Graph Algorithm")]
    [TestClass]
    public class HasPathProblemTests
    {
        public readonly HasPathProblem _sut;

        public HasPathProblemTests()
        {
            _sut = new HasPathProblem();
        }

        [TestMethod]
        public void ShouldSuccessWhenProvidedPathExists_DFS()
        {
            var graph = new Dictionary<char, char[]>()
            {
                { 'f',new char[] {'g', 'i'} },
                { 'g',new char[] {'h'} },
                { 'h',Array.Empty<char>()},
                { 'i',new char[] {'g', 'k'} },
                { 'j',new char[] {'i'} },
                { 'k',Array.Empty<char>()},
            };


            var actual = _sut.HasPathUsingDfs(graph, 'f', 'k');

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ShouldFailWhenProvidedPathNotExists_DFS()
        {
            var graph = new Dictionary<char, char[]>()
            {
                { 'f',new char[] {'g', 'i'} },
                { 'g',new char[] {'h'} },
                { 'h',Array.Empty<char>()},
                { 'i',new char[] {'g', 'k'} },
                { 'j',new char[] {'i'} },
                { 'k',Array.Empty<char>()},
            };


            var actual = _sut.HasPathUsingDfs(graph, 'f', 'c');

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ShouldSuccessWhenProvidedPathExists_DFSRecursive()
        {
            var graph = new Dictionary<char, char[]>()
            {
                { 'f',new char[] {'g', 'i'} },
                { 'g',new char[] {'h'} },
                { 'h',Array.Empty<char>()},
                { 'i',new char[] {'g', 'k'} },
                { 'j',new char[] {'i'} },
                { 'k',Array.Empty<char>()},
            };


            var actual = _sut.HasPathUsingDfsRecursive(graph, 'f', 'k');

            Assert.AreEqual(true,actual);
        }

        [TestMethod]
        public void ShouldFailWhenProvidedPathNotExists_DFSRecursive()
        {
            var graph = new Dictionary<char, char[]>()
            {
                { 'f',new char[] {'g', 'i'} },
                { 'g',new char[] {'h'} },
                { 'h',Array.Empty<char>()},
                { 'i',new char[] {'g', 'k'} },
                { 'j',new char[] {'i'} },
                { 'k',Array.Empty<char>()},
            };


            var actual = _sut.HasPathUsingDfsRecursive(graph, 'f', 'c');

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ShouldSuccessWhenProvidedPathExists_BFS()
        {
            var graph = new Dictionary<char, char[]>()
            {
                { 'f',new char[] {'g', 'i'} },
                { 'g',new char[] {'h'} },
                { 'h',Array.Empty<char>()},
                { 'i',new char[] {'g', 'k'} },
                { 'j',new char[] {'i'} },
                { 'k',Array.Empty<char>()},
            };


            var actual = _sut.HasPathUsingBfs(graph, 'f', 'k');

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ShouldFailWhenProvidedPathNotExists_BFS()
        {
            var graph = new Dictionary<char, char[]>()
            {
                { 'f',new char[] {'g', 'i'} },
                { 'g',new char[] {'h'} },
                { 'h',Array.Empty<char>()},
                { 'i',new char[] {'g', 'k'} },
                { 'j',new char[] {'i'} },
                { 'k',Array.Empty<char>()},
            };


            var actual = _sut.HasPathUsingBfs(graph, 'f', 'c');

            Assert.AreEqual(false, actual);
        }
    }
}
