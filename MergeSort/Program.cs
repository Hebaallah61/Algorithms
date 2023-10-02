namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array =new() { 8, 65, 9, 7, 3, 5, 54 };

            Console.WriteLine(String.Join(", ", array));
            MergeAlgo.MergeSort(array, 0, array.Count - 1);
            Console.WriteLine(String.Join(", ", array));
        }
    }
}