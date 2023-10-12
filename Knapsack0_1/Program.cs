namespace Knapsack0_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
            {
                new Item("#1", 1, 4),
                new Item("#2", 3, 9),
                new Item("#3", 5, 12),
                new Item("#4", 4, 11)
            };
            int MaxWeight = 8;
            knapsack0_1Algo.knapsack0_1(items,MaxWeight);
        }
    }
}