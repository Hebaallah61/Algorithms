using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_sShortestPath
{
    public class Graph
    {
        private int last_index = 0;
        public Vertex[] Vertices;

        public Graph(string[] names)
        {
            Vertices = new Vertex[names.Length];
            foreach (string name in names)
            {
                Vertices[last_index] = new Vertex();
                Vertices[last_index].Name = name;
                last_index++;
            }
        }
        public void AddEdges(int vertexIndexCurrent, int[] targets, double[] weights)
        {
            Vertices[vertexIndexCurrent].VertexLink = new Edge[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                Vertices[vertexIndexCurrent].VertexLink[i] = new Edge(Vertices[vertexIndexCurrent], Vertices[targets[i]], weights[i]);
            }
        }
        /// <summary>
        /// Complexity==> O(V*E),O(V^2), where V is the number of vertices & E number of Edges 
        /// Performs a Dijkstra shortest path algorithm on the graph starting from the first vertex.
        /// 1- make total lenght for all vertices equal infinity except the first make it zero 
        /// 2- for i=1 to vertices lenght 
        ///   2.1- if destination ==null continue ==> the vertex is disconnected 
        ///   2.2- for each unvisited neighbor U of V do
        ///      2.2.1- newLength = V.TotalLength + length of the edge from V to U
        ///      2.2.2- If newLength < U.TotalLength:
        ///           2.2.2.1- Update U.TotalLength to newLength
        ///           2.2.2.2- Set U.SourceOfTotalLength to V
        /// 3- print
        /// </summary>

        public void Dijkstra()
        { 
            for(int i=1; i<Vertices.Length; i++)
            {
                Vertices[i].TotalLength = double.MaxValue;
            }

            Vertex Current;
            for (int i = 0; i < Vertices.Length; i++)
            {
                Current = Vertices[i];
                Edge[] destination = Current.VertexLink;
                if (destination == null) continue;

                Edge currentEdge;
                for(int j=0;j<destination.Length; j++)
                {
                    currentEdge = destination[j];
                    double newLength = Current.TotalLength + currentEdge.Weight;
                    if(newLength< currentEdge.Destination.TotalLength)
                    {
                        currentEdge.Destination.TotalLength= newLength;
                        currentEdge.Destination.SourceOfTotalLength = Current;
                    }
                }
            }
            string path = Vertices[Vertices.Length-1].Name;
            Vertex v = Vertices[Vertices.Length - 1];
            while (v.SourceOfTotalLength != null)
            {
                path = v.SourceOfTotalLength.Name + "->" + path;
                v = v.SourceOfTotalLength;
            }
            Console.WriteLine(Vertices[Vertices.Length-1].TotalLength);
            Console.WriteLine(path);
        }
    }
}

