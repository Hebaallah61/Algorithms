namespace SortedCharactersFrequencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCIIMethod\n");
            CharFreq.ASCIIMethod("hello world");
            Console.WriteLine("\nUTF8CodeMethod\n");
            CharFreq.UTF8CodeMethod("hello world_$&*|");
        }
    }
}