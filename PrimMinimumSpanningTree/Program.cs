﻿namespace PrimMinimumSpanningTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] labels = new char[] { '1', '2', '3', '4', '5', '6' };
            double[,] graph = new double[,] {
                                              { 0, 6.7, 5.2, 2.8, 5.6, 3.6 },
                                              { 6.7, 0, 5.7, 7.3, 5.1, 3.2 },
                                              { 5.2, 5.7, 0, 3.4, 8.5, 4.0 },
                                              { 2.8, 7.3, 3.4, 0, 8, 4.4 },
                                              { 5.6, 5.1, 8.5, 8, 0, 4.6 },
                                              { 3.6, 3.2, 4, 4.4, 4.6, 0 }
                                            };

            int vertics = 6;
            PrimMSTAlgo.MST(labels, graph, vertics);
        }
    }
}