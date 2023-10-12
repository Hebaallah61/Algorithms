using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageCoach
{
    public class StageCoachAlgo
    {
        /// <summary>
        /// Complexity=> O(n^2) because of nested loop
        /// 1- for i=n-2 to 0
        ///     1.1- currentPointTotalCost= max_num in your language
        ///     1.2- for j= i+1 to n,
        ///         1.2.1- newCost=matrix(i,j)+totalCost(j)
        ///         1.2.2- currentPointTotalCost=min(currentPointTotalCost, newCost)
        /// 2- totalCost(i)= currentPointTotalCost;
        /// </summary>

        public static void StageCoach(int[,] data, string[] labels )
        {
            int n= data.GetLength(0);
            Dictionary<string, dynamic>[] states = new Dictionary<string, dynamic>[n];

            states[n - 1] = new Dictionary<string, dynamic>
            {
                { "from", "" },
                { "to", "" },
                { "cost", 0 }
            };
            
            for(int i = n - 2;i>=0;i--) //-2 not 1 because j there is no thing after it 
            {
                states[i] = new Dictionary<string, dynamic>
                {
                    { "from", labels[ i] },
                    { "to", labels[ i + 1] },
                    { "cost", int.MaxValue }
                };
                for (int j=i+1; j < n; j++)
                {
                    if (data[i, j] == 0) continue;
                    int newCost = data[i, j] + states[j]["cost"];
                    if(newCost< states[i]["cost"])
                    {
                        states[i]["to"] = labels[j];
                        states[i]["cost"] = newCost;
                    }

                }
            }
            Print(states);
        }
        private static void Print(Dictionary<string, dynamic>[] states)
        {
            foreach (var state in states)
            {
                Console.WriteLine($"From: {state["from"]}, To: {state["to"]}, Cost: {state["cost"]}");
            }

            Console.WriteLine($"Minimum Cost:{states[0]["cost"]}");

            int i = 0, j = 0;
            List<string> path = new List<string> { "A" };

            while (i< states.Length)
            {
                if (states[i]["from"] == path[j])
                {
                    path.Add(states[i]["to"]);
                    j++;
                }
                i++;
            }

            Console.WriteLine("Minimum Path: " + string.Join(" -> ", path));
        }
    }
}
