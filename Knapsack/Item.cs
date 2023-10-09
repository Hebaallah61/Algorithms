using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    public class Item
    {
        public string Name;
        public float Profit;
        public int Weight;
        public float Ratio;

        public Item(string name, float profit, int weight)
        {
            Name = name;
            Profit = profit;
            Weight = weight;
            Ratio = profit / weight;
        }
    }
}
