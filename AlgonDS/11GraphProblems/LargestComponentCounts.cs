using System.Collections.Generic;
using System.Diagnostics;

namespace AlgonDS._11GraphProblems
{
    public class LargestComponentCounts
    {
        public int GetCount(Dictionary<int,int[]> graph)
        {
            var visited = new HashSet<int>();
            var count = 0;
            
            foreach (var node in graph)
            {
                var nodeCount = CollectCount(graph, node.Key, visited);
                //Debug.WriteLine(nodeCount);
                if (nodeCount > count)
                    count = nodeCount;
            }

            return count;
        }

        private int CollectCount(Dictionary<int, int[]> graph, int node, HashSet<int> visited)
        {
            if (visited.Contains(node)) return 0;

            visited.Add(node);

            var nodeCount = 1;

            foreach (var neighbor in graph[node])
            {
                nodeCount+= CollectCount(graph, neighbor, visited);
            }

            return nodeCount;
        }
    }
}
