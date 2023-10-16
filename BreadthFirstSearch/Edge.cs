using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    public class Edge
    {
        public Vertex Source;
        public Vertex Destination;
        public double Weight;

        public Edge(Vertex source, Vertex destination, double weight=0)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}
