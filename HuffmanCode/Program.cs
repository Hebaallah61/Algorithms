namespace HuffmanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HuffmanCodeAlgo huffman = new("internet");
            HuffmanCodeAlgo.PrintCodes(huffman);
        }
    }
}