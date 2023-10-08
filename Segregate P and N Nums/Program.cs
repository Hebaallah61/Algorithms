namespace Segregate_P_and_N_Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array1 = new() { 9,-3,5,-2,-8,-6,1,3};

            Console.WriteLine(String.Join(", ", array1));
            Segregate_P_N.Segregate(array1, 0, array1.Count - 1);
            Console.WriteLine(String.Join(", ", array1));

            List<int> array2 = new() { -9, -3, 5, -2, -8, -6, 1, 3 };
            Console.WriteLine(String.Join(", ", array2));
            List<int> Result=Segregate_Norm_P_N.Segregate(array2);
            Console.WriteLine(String.Join(", ", Result));
        }
    }
}