namespace Segregate_P_and_N_Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new() { 9,-3,5,-2,-8,-6,1,3};

            Console.WriteLine(String.Join(", ", array));
            Segregate_P_N.Segregate(array, 0, array.Count - 1);
            Console.WriteLine(String.Join(", ", array));
        }
    }
}