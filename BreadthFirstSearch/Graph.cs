using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
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
        /// Performs a Breadth-First Search (BFS) on the graph starting from the first vertex.
        /// 1- Create an empty queue Q
        /// 2- Mark Start vertex as visited and enqueue it into q
        /// 3- while q is not empty do
        ///   3.1- Dequeue a vertex V from q
        ///   3.2- for each unvisited neighbor U of V do
        ///      3.2.1- Enqueue U into q 
        ///      3.2.2- Mark U as visited
        ///      3.2.3- print
        /// </summary>
        public void BFS()
        {
            int v=Vertices.Length; 
            Queue<Vertex> q = new Queue<Vertex>(v);
            q.Enqueue(Vertices[0]);
            Vertices[0].Visited = true;
            Vertex Current;

            while(q.Count > 0)
            {
                Current = q.Dequeue();
                for(int i = 0; i < Current.VertexLink.Length; i++)
                {
                    if (Current.VertexLink[i].Destination.Visited == false)
                    {
                        q.Enqueue(Current.VertexLink[i].Destination);
                        Current.VertexLink[i].Destination.Visited = true;
                        Console.WriteLine(Current.Name + " - "+ Current.VertexLink[i].Destination.Name);
                    }
                }
            }
        }
     }
}
