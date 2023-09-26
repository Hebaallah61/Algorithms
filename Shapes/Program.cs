namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trapezoid T1 = new();
            var R1=T1.Area(4, 6, 3);
            Parallelogram P1 = new();
            var R2 = P1.Area(6, 8);
            Console.WriteLine(R1);
            Console.WriteLine(R2);


        }
    }
}