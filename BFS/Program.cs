using BFSWithoutOOP;
using System.Collections;

namespace BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = 9;
            Hashtable g = new();
            g.Add('A', new char[] { 'B', 'C' });
            g.Add('B', new char[] { 'E', 'D', 'A' }) ;
            g.Add('C', new char[] { 'D','F' , 'A' }) ;
            g.Add('D', new char[] { 'E', 'F', 'B' });
            g.Add('E', new char[] { 'F', 'B' });
            g.Add('F', new char[] { 'D', 'E', 'C', 'H' });
            g.Add('G', new char[] { 'H', 'I' });
            g.Add('H', new char[] { 'G', 'I', 'F' });
            g.Add('I', new char[] { 'G', 'H' });

            BFSAlgo.BFS(g, v);
        }
    }
}