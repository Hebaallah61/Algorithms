using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    /// <summary>
    /// Complexity==> O(n log n) because of merge sort
    /// 1- Calculate the ratio of the profit for each single kilo of the item
    /// 2- sort the item by ratio from the largest to the smallest
    /// 3- while knapsack if not full
    /// 4- foreach item 
    ///    4.1- if item weight is less than the current knapsack cpacity then
    ///        4.1.1- add item as is in the knapsack
    ///    4.2- else 
    ///        4.2.1- add fraction of item
    /// </summary>
    public class KnapsackAlgo
    {
        public int MaxCapacity;
        public int CurrentCapacity;
        public float TotalProfit;
        public List<Item> Items=new();

        public KnapsackAlgo(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
        }

        public void AddItem(Item item)
        {
            if(item.Weight > MaxCapacity - CurrentCapacity)
            {
                item.Weight = MaxCapacity - CurrentCapacity;
                item.Profit = item.Weight * item.Ratio;
            }
            Items.Add(item);
            CurrentCapacity += item.Weight;
            TotalProfit+= item.Profit;
        }

        public static void KnapSack(List<int> profit, List<int> weight, int maxCapacity)
        {
            List<Item> items = new();
            int i = 0;
            foreach(int item in profit)
            {
                Item newItem = new($"#{i}", profit[i], weight[i]);
                items.Add(newItem);
                i++;
            }

            MergeSortAlgo.MergeSort(items, 0, items.Count-1);

            int j = 0;
            KnapsackAlgo bag = new(maxCapacity);
            while (bag.CurrentCapacity < maxCapacity)
            {
                bag.AddItem(items[j++]);
            }

            PrintItems(bag);
        }
        private static void PrintItems(KnapsackAlgo bag)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Total Profit:"+ bag.TotalProfit);
            Console.WriteLine("Current Capacity:"+ bag.CurrentCapacity);
            Console.WriteLine("items:");
            Console.WriteLine("n\tp\tw");
            foreach (Item item in bag.Items)
                Console.WriteLine($"{item.Name}\t{item.Profit}\t{item.Weight}");
        }
    }
}
