using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_sShortestPath
{
    public class Vertex
    {
        public string Name;
        public bool Visited;
        public Edge[] VertexLink;
        public double TotalLength;
        public Vertex SourceOfTotalLength;
    }
}
