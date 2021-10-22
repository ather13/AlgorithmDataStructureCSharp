using System.Collections.Generic;

namespace AlgonDS._11GraphProblems
{
    public class Helper
    {
        public Dictionary<char, List<char>> Convert(char[][] graph)
        {
            var convertedGraph = new Dictionary<char, List<char>>();

            foreach (var node in graph)
            {
                if (!convertedGraph.ContainsKey(node[0]))
                {
                    convertedGraph.Add(node[0],new List<char>());
                }
                if (!convertedGraph.ContainsKey(node[1]))
                {
                    convertedGraph.Add(node[1], new List<char>());
                }
                convertedGraph[node[0]].Add(node[1]);
                convertedGraph[node[1]].Add(node[0]);
            }

            return convertedGraph;
        }
    }
}
