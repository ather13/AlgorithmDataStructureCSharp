using System.Collections.Generic;

namespace AlgonDS._11GraphProblems
{
    public class ConnectedComponentCounts
    {
        /// <summary>
        /// Get count of components which are disconnected
        /// Used Visited as graph is undirected / bidirectional graph
        /// </summary>
        /// <param name="graph"></param>
        public int GetConnectedComponentCounts(Dictionary<int,int[]> graph)
        {
            var visited = new HashSet<int>();
            var count = 0;

            foreach (var node in graph)
            {
                if (explore(graph, node.Key, visited))
                {
                    count++;
                }
            }

            return count;
        }

        private bool explore(Dictionary<int, int[]> graph, int node,HashSet<int> visited)
        {
            if (visited.Contains(node)) return false;

            visited.Add(node);

            foreach (var neighbor in graph[node])
            {
                explore(graph, neighbor, visited);
            }

            return true;
        }
    }
}
