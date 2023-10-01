namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortedList = InsertionAlgo.InsertionSort(new List<int> { 1, 5, 20, 2, 7 });
            Console.WriteLine(string.Join(",", sortedList));
        }
    }
}