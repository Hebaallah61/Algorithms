using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack0_1
{
    public class Item
    {
        public string Name;
        public int Weight;
        public int Profit;

        public Item(string name, int weight, int profit)
        {
            Name = name;
            Weight = weight;
            Profit = profit;
        }
    }
}
