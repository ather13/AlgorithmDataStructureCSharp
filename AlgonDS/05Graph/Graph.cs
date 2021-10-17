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
    public class Graph<T>
    {
        public Dictionary<T, HashSet<T>>
        Neighbors = new Dictionary<T, HashSet<T>>();

        public void AddVertex(T data)
        {
            Neighbors.Add(data, new HashSet<T>());
        }

        public void AddVertex(T[] data)
        {
            foreach (var d in data)
            {
                AddVertex(d);
            }
        }

        public void AddEdges(T v1, T v2)
        {
            if (Neighbors.ContainsKey(v1) && Neighbors.ContainsKey(v2))
            {
                Neighbors[v1].Add(v2);
                Neighbors[v2].Add(v1);
            }
        }

        public void AddEdges(IEnumerable<Tuple<T, T>> list)
        {
            foreach (var o in list)
            {
                AddEdges(o.Item1, o.Item2);
            }
        }
    }
}

