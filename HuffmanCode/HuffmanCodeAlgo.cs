using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
    /// <summary>  Complexity ===> O(n log n) according to priority queue 
    /// using priority Queue[min_heap] for sorting by frequence (min frequence)
    /// 0- Huffman(C)
    /// 1- n|C|
    /// 2- Q C
    /// 3- for i 1 to n-1
    /// 4- do z Allocate-node()
    /// 5- x left[z] extract_min(Q)
    /// 6- y right[z] extract_min(Q)
    /// 7- f[z] f[x]+f[y]
    /// 8- insert(Q, Z)
    /// 9- return extract_min(Q)
    /// </summary>
    public class HuffmanCodeAlgo
    {
        private PriorityQueue<HeapNode, int> minHeap = new();
        public Hashtable codes = new Hashtable();
        private char dummyData_char = (char)0;

        public HuffmanCodeAlgo(string message)
        {
            Hashtable freq = new();
            int i;
            for(i=0;i<message.Length;i++) // n
            {
                if (freq[message[i]]==null) freq[message[i]]=1;
                else freq[message[i]] = (int)freq[message[i]]! + 1;
            }

            foreach(char c in freq.Keys) // n
            {
                HeapNode heapNode = new(c, (int)freq[c]!);
                minHeap.Enqueue(heapNode, (int)freq[c]!); // n log n
            }

            HeapNode top, left, right;
            int newFreq;
            while (minHeap.Count != 1) // n
            {
                left = minHeap.Dequeue();
                right = minHeap.Dequeue();
                newFreq= left.Freq + right.Freq;
                top=new(dummyData_char, newFreq);
                top.Right = right;
                top.Left=left;
                minHeap.Enqueue(top, newFreq);
            }
            GenerateCodes(minHeap.Peek(), "");

        }
        private void GenerateCodes(HeapNode heapNode, string str)
        {
            if (heapNode == null) return;
            if(heapNode.Data!= dummyData_char) codes[heapNode.Data] = str;
            GenerateCodes(heapNode.Left, str+"0");
            GenerateCodes(heapNode.Right, str+"1");
        }

        public static void PrintCodes(HuffmanCodeAlgo huffman)
        {
            foreach(char c in huffman.codes.Keys) // n
            {
                Console.Write(c + " ");
                Console.WriteLine(huffman.codes[c]);
            }
        }
    }
}
