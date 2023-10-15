using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimMinimumSpanningTree
{
    public class PrimMSTAlgo
    {
        /// <summary>
        /// complexity==> O(V^3) where v is number of vertices in graph 
        /// 1- add first arbitrary vertics in the solution
        /// 1- while selected edges count < V-1 [vertics]
        ///   1.1- create min store with bigest possible value in your language
        ///   1.2- create temp store for the possible of the min in the graph 
        ///   1.3- for i=0, i< V
        ///      1.3.1- if i is in solution
        ///            1.3.1.1- for j=0, j< V
        ///                    1.3.1.1.1- if j is not the solution & graph[i,j]>0 & <min
        ///                             1.3.1.1.1.1- assign graph[i,j] to min
        ///                             1.3.1.1.1.2- assign i,j to the position temp store
        ///   1.4- add temp position to the solution
        ///   1.5- increase selected edges count by one
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="graph"></param>
        /// <param name="vertics"></param>
        public static void MST(char[] labels, double[,] graph, int vertics)
        {
            int selectededges = 0;
            bool[] selected = new bool[vertics];// solution  // default false
            selected[0] = true; // start that i prefere  
            while (selectededges < vertics - 1)
            {
                double min = double.MaxValue;
                int tempFrom = -1;
                int tempTo = -1; 
                for(int i = 0; i < vertics; i++)
                {
                    if (selected[i] == true)
                    {
                        for(int j = 0;j<vertics; j++)
                        {
                            if (selected[j] != true && graph[i,j]>0 && graph[i,j]<min)
                            {
                                min= graph[i,j];
                                tempFrom = i;
                                tempTo=j;
                            }
                        }

                    }
                }
                selected[tempTo] = true;
                selectededges++;
                Console.Write(labels[tempFrom] + " - ");
                Console.Write(labels[tempTo] + " : ");
                Console.WriteLine(graph[tempFrom, tempTo]);
            }
        }
    }
}
