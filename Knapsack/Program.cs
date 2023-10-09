namespace Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KnapsackAlgo.KnapSack(new() { 4, 9, 12, 11, 6, 5 }, new() { 1, 2, 10, 4, 3, 5 }, 12);
        }
    }
}