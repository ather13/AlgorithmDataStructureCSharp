using System;
using System.Collections.Generic;

/// <summary>
/// Problem Statement : A graph is a pictorial representation of a set of objects where some pairs of objects 
/// are connected by links. The interconnected objects are represented by points termed as vertices, 
/// and the links that connect the vertices are called edges.
/// Formally, a graph is a pair of sets(V, E), where V is the set of vertices and E is the set of edges, 
/// connecting the pairs of vertices.
/// </summary>

namespace AlgonDS
{
    public class Graph
    {
        public Dictionary<int, HashSet<int>>
        Neighbours = new Dictionary<int, HashSet<int>>();

        public void AddVertex(int data)
        {
            Neighbours.Add(data, new HashSet<int>());
        }

        public void AddVertex(int[] data)
        {
            foreach (var d in data)
            {
                AddVertex(d);
            }
        }

        public void AddEdges(int v1, int v2)
        {
            if (Neighbours.ContainsKey(v1) && Neighbours.ContainsKey(v2))
            {
                Neighbours[v1].Add(v2);
                Neighbours[v2].Add(v1);
            }
        }

        public void AddEdges(IEnumerable<Tuple<int, int>> list)
        {
            foreach (var o in list)
            {
                AddEdges(o.Item1, o.Item2);
            }
        }
    }
}

