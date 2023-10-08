using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
    public class HeapNode
    {
        public char Data;
        public int Freq;
        public HeapNode Left;
        public HeapNode Right;

        public HeapNode(char data, int freq)
        {
            Data = data;
            Freq = freq;
            Left = Right= null;
        }
    }
}
