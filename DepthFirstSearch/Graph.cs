using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    public class Graph
    {
        private int last_index = 0;
        public Vertex[] Vertices;

        public Graph(string[] names)
        {
            Vertices = new Vertex[names.Length];
            foreach(string name in names)
            {
                Vertices[last_index] = new Vertex();
                Vertices[last_index].Name = name;
                last_index++;
            }
        }
        public void AddEdges(int vertexIndexCurrent, int[] targets)
        {
            Vertices[vertexIndexCurrent].VertexLink = new Edge[targets.Length];
            for(int i = 0;i<targets.Length;i++)
            {
                Vertices[vertexIndexCurrent].VertexLink[i]=new Edge(Vertices[vertexIndexCurrent],Vertices[targets[i]]);
            }
        }
        /// <summary>
        /// Complexity==> O(V+E), where V is the number of vertices & E number of Edges 
        /// Performs a Depth-First Search (DFS) on the graph starting from the first vertex.
        /// 1- Call DFSRecursion(first vertix)
        /// 2- DFSRecursion:
        ///   2.1- Mark first vertix as visited
        ///   2.2- for each unvisited neighbor U of V do
        ///      2.2.1- if U unvisited
        ///           2.2.1.1- print
        ///           2.2.1.2- Call DFSRecursion(next vertix)
        /// </summary>

        public void DFS()
        {
            DFSRecursion(Vertices[0]);
        }
        private void DFSRecursion(Vertex Current )
        {
            Current.Visited = true;
            
            for(int i = 0; i < Current.VertexLink.Length; i++)
            {
                if (Current.VertexLink[i].Destination.Visited == false)
                {
                    Console.WriteLine(Current.Name + " - "+ Current.VertexLink[i].Destination.Name);
                    DFSRecursion(Current.VertexLink[i].Destination);
                }
            }
        }
    }
}

