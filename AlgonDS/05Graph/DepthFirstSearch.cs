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
        //here root is any starting point
        //since there is no root element in graph
        public bool Search(Graph<int> graph, int root, int searchValue)
        {
            var visited = new List<int>();
            var stack = new Stack<int>();

            if (graph == null) return false;

            if (!graph.Neighbours.ContainsKey(root)) return false;

            if (root == searchValue) return true;

            stack.Push(root);

            while (stack.Count() > 0)
            {
                var vertex = stack.Pop();

                if (visited.Contains(vertex)) continue;

                if (vertex == searchValue) return true;

                visited.Add(vertex);

                foreach (var v in graph.Neighbours[vertex])
                {
                    if (!visited.Contains(v))
                    {
                        stack.Push(v);
                    }
                }
            }

            return false;
        }
    }
}
