using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSWithoutOOP
{
    public class BFSAlgo
    {
        public static void BFS(Hashtable graph, int v)
        {
            Queue<char> queue = new Queue<char>(v);
            queue.Enqueue('A');
            Hashtable Visited = new Hashtable();
            Visited.Add('A', true);

            while (queue.Count > 0)
            {
                char Current = queue.Dequeue();
                char[] neighbors = (char[])graph[Current];

                foreach (char neighbor in neighbors)
                {
                    if (!Visited.ContainsKey(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        Visited.Add(neighbor, true);
                        Console.WriteLine(Current + " - " + neighbor);
                    }
                }
            }
        }
    }
}
