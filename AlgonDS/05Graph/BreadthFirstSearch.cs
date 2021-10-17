using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

/// <summary>
/// Problem Statement : Breadth First Search (BFS) algorithm traverses a graph in a breadthward motion 
/// and uses a queue to remember to get the next vertex to start a search, when a dead end occurs in any 
/// iteration.
/// </summary>

namespace AlgonDS
{
    public class BreadthFirstSearch
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
            var queue = new Queue<int>();

            if (graph == null) return false;

            if (!graph.Neighbors.ContainsKey(root)) return false;

            if (root == searchValue) return true;

            queue.Enqueue(root);

            while (queue.Any())
            {
                var vertex = queue.Dequeue();
                //Debug.WriteLine(vertex);
                if (visited.Contains(vertex)) continue;

                if (vertex == searchValue) return true;

                visited.Add(vertex);

                foreach (var v in graph.Neighbors[vertex])
                {
                    if (!visited.Contains(v))
                    {
                        queue.Enqueue(v);
                        // Debug.WriteLine(v);
                    }
                }
            }

            return false;
        }
    }
}
