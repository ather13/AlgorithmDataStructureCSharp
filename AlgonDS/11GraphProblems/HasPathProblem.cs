using System.Collections.Generic;
using System.Linq;

namespace AlgonDS._11GraphProblems
{
    /// <summary>
    /// Find if two given nodes has path in directed acyclic graph 
    /// </summary>
    public class HasPathProblem
    {
        /// <summary>
        /// Verify path using Depth First Algorithm - Recursive
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool HasPathUsingDfsRecursive(Dictionary <char, char[]> graph, char source, char target)
        {
            if (graph == null || !graph.Any()) return false;

            if (source == default(char) || target == default(char)) return false;

            if (source == target) return true;

            foreach (var neighbor in graph[source])
            {
                if (HasPathUsingDfsRecursive(graph, neighbor, target))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verify path using Depth First Algorithm - Non Recursive
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool HasPathUsingDfs(Dictionary<char, char[]> graph, char source, char target)
        {
            if (graph == null || !graph.Any()) return false;

            if (source == default(char) || target == default(char)) return false;

            var stack = new Stack<char>();
            stack.Push(source);

            while (stack.Any())
            {
                var current = stack.Pop();

                if (current == target) return true;

                foreach (var neighbor in graph[current])
                {
                    stack.Push(neighbor);
                }
            }

            return false;
        }

        /// <summary>
        /// Verify path using Breath First Algorithm
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool HasPathUsingBfs(Dictionary<char, char[]> graph, char source, char target)
        {
            if (graph == null || !graph.Any()) return false;

            if (source == default(char) || target == default(char)) return false;
            
            var queue = new Queue<char>();
            queue.Enqueue(source);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (current == target) return true;

                foreach (var neighbor in graph[current])
                {
                    queue.Enqueue(neighbor);
                }
            }

            return false;
        }
    }
}
