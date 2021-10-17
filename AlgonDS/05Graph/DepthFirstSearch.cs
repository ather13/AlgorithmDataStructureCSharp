using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Problem Statement: Depth First Search (DFS) algorithm traverses a graph in a depthward motion 
/// and uses a stack to remember to get the next vertex to start a search, when a dead end occurs in any 
/// iteration. 
/// </summary>

namespace AlgonDS
{
    public class DepthFirstSearch
    {
        /// <summary>
        /// here root is any starting point
        /// since there is no root element in graph like in tree
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="root"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public bool Search(Graph<int> graph, int root, int searchValue)
        {
            var visited = new List<int>(); // this is only needed for bidirectional graph
            var stack = new Stack<int>();

            if (graph == null) return false;

            if (!graph.Neighbors.ContainsKey(root)) return false;

            if (root == searchValue) return true;

            stack.Push(root);

            while (stack.Any())
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex)) continue;

                if (vertex == searchValue) return true;

                visited.Add(vertex);

                foreach (var v in graph.Neighbors[vertex])
                {
                    if (!visited.Contains(v))
                    {
                        stack.Push(v);
                    }
                }
            }

            return false;
        }

        public bool SearchRecursive(Graph<int> graph, int root, int searchValue,IList<int> visited=null)
        {
            if (graph == null) return false;

            if (!graph.Neighbors.ContainsKey(root)) return false;

            if (root == searchValue) return true;

            visited ??= new List<int>(); // this is only needed for bidirectional graph

            visited.Add(root);

            foreach (var neighbor in graph.Neighbors[root])
            {
                if (!visited.Contains(neighbor))
                {
                    return SearchRecursive(graph, neighbor, searchValue, visited);
                }
            }

            return false;
        }
    }
}
