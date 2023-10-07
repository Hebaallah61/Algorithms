namespace ActivitySelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new();

            result= ActivitySelectionAlgo.ActivitySelection
                (new List<int> { 9, 10, 11, 12, 13, 15 },
                new List<int> { 11, 11, 12, 14, 15, 16 });

            Console.WriteLine(string.Join(", ", result));
        }
    }
}