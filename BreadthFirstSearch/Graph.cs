using System;
using System.Collections.Generic;
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
