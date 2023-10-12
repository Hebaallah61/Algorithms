using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack0_1
{
    public class knapsack0_1Algo
    {
        /// <summary>
        /// complexit O(N * W) because of nested for loop where N is number of items and W maximum weight 
        /// 1- if item weight<= current stage weight=>j 
        ///   1.1- cell value= Max of(profit of item+ value of cell at : j=difference between j weight & item weight, i=top row || top cell value
        /// 2- else
        ///   2.1- cell value= top cell value
        /// </summary>
        /// <param name="List">items</param>
        /// <param name="MaxWeight"></param>
        public static void knapsack0_1(List<Item> List, int MaxWeight)
        {
            int[][] matrix = new int[List.Count + 1][];
            for (int i = 0; i <= List.Count; i++)
            {
                matrix[i] = new int[MaxWeight + 1];
            }

            for (int i = 0; i <= List.Count; i++)
            {
                for (int j = 0; j <= MaxWeight; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        matrix[i][j] = 0;
                    }
                    else if (List[i-1].Weight <= j) 
                    {
                        matrix[i][j] = Math.Max(List[i - 1].Profit + matrix[i - 1][j - List[i - 1].Weight], matrix[i - 1][j]);
                    }
                    else
                    {
                        matrix[i][j] = matrix[i - 1][j];
                    }
                }
            }
            PrintResult(matrix, List, MaxWeight);
        }
        /// <summary>
        /// 1- start from the bottom right 
        /// 2- remain =max weight
        /// 3- while remain>0 
        ///   3.1- if value> topvalue
        ///       3.1.1- item is part of solution 
        ///       3.1.2- remain= remain - item weight
        ///       3.1.3- go to column[remain]
        ///       3.1.4- go to top row
        ///   3.2- else
        ///       3.2.1- move to top row
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="list"></param>
        /// <param name="maxWeight"></param>
        private static void PrintResult(int[][] matrix, List<Item> list, int maxWeight)
        {
            Console.WriteLine("Max Profit: " + matrix[list.Count][maxWeight]);

            List<string> result = new List<string>();
            int i = list.Count;
            int j = maxWeight;
            int weightRemaining = maxWeight;

            while (weightRemaining > 0 && i > 0)
            {
                if (matrix[i][j] != matrix[i - 1][j])
                {
                    result.Add(list[i - 1].Name);
                    weightRemaining -= list[i - 1].Weight;
                    j -= list[i - 1].Weight;
                }
                i--;
            }

            Console.WriteLine("Selected Items: " + string.Join(", ", result));

        }
    }
}
