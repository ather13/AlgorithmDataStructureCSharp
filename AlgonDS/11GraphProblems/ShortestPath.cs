using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._11GraphProblems
{
    /// <summary>
    /// BFS is easy way to find shortest path
    /// </summary>
    public class ShortestPath
    {
        public int GetShortestPath(Dictionary<char,List<char>> graph,char start, char end)
        {   
            return FindPath(graph, start, end);
        }

        private int FindPath(Dictionary<char, List<char>> graph, char start, char end)
        {
            var visited = new HashSet<char>();
            var queue = new Queue<(char node, int distance)>();
            var counter = -1;

            queue.Enqueue((start,0));

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (current.node == end)
                {
                    counter = current.distance;
                    break;
                }

                if (visited.Contains(current.node)) continue;

                visited.Add(current.node);

                foreach (var neighbor in graph[current.node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue((neighbor, current.distance + 1));
                    }
                }
            }

            return counter;
        }
    }
}
