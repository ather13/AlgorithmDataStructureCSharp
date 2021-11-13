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
            var count = 1;

            foreach (var node in graph)
            {
                if (Explore(graph, node.Key, visited))
                {
                    count++;
                }
            }

            return count;
        }

        private bool Explore(IReadOnlyDictionary<int, int[]> graph, int node,ISet<int> visited)
        {
            if (visited.Contains(node)) return false;

            visited.Add(node);

            foreach (var neighbor in graph[node])
            {
                Explore(graph, neighbor, visited);
            }

            return true;
        }
    }
}
