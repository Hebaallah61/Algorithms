﻿namespace StageCoach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] labels = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int[,] data = {
            {0, 2, 4, 3, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 7, 4, 6, 0, 0, 0},
            {0, 0, 0, 0, 3, 2, 4, 0, 0, 0},
            {0, 0, 0, 0, 4, 1, 5, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 1, 4, 0},
            {0, 0, 0, 0, 0, 0, 0, 6, 3, 0},
            {0, 0, 0, 0, 0, 0, 0, 3, 3, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 3},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };
            StageCoachAlgo.StageCoach(data, labels);

        }
    }
}