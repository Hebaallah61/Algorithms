using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SortedCharactersFrequencies
{
    public class CharFreq
    {
        /// <summary>
        /// 1- if we have two arrays only
        /// 2- create array length=127 ==>each index represent one char ASCII Code , value of item is the frequence of the char
        /// 3- for each char in the text
        ///     3.1-find the proper index by getting the ASCII decimal code for the char
        ///        3.1.1- increase the item value by 1
        /// 4- print the array
        /// </summary>
        public static void ASCIIMethod(string message)
        {
            int[] freq= new int[127];
            for (int i = 0; i < message.Length; i++)
            {
                int code = (int)message[i];
                freq[code]++;
            }
            for(int i=0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"{(char)i} = {freq[i]}");
                }
            }

        }

        ///<summary>
        /// 1- inputs: text [UTF8]
        /// 2- outputs: the freq of each unique char after sorted by freq
        /// 3- using: HashTable
        /// --------------------------------------------------------------
        /// 1- create Hashtable, the char is the key, the freq is the value 
        /// 2- foreach char in the string
        /// 2.1- check if there is a key in the hashtable with the same char. 
        ///    2.1.1- if not exist then
        ///          2.1.1.1- create a new one with value 1
        ///    2.1.2- if exist then 
        ///          2.1.1.2- get the value of it and increase it by 1
        /// 3- print the hashtable
        /// 4- Sort the hashtable by convert it to array 
        /// 5- use Merge Sort 
        /// </summary>
        public static void UTF8CodeMethod(string message)
        {
            Hashtable freq = new();

            for(int i=0;i< message.Length;i++)
            {
                if (freq[message[i]] == null) freq[message[i]] = 1;
                else freq[message[i]] = (int) freq[message[i]]! + 1;
            }

            foreach(char c in freq.Keys)
            {
                Console.WriteLine($"{c}==>{freq[c]}");
            }
            SortHash(freq);
        }
         static void SortHash(Hashtable freq)
        {
            int[,] freqarr = new int[freq.Count, 2]; // rows=> freq.count, columns=> key, value
            int i = 0;
            foreach(char c in freq.Keys)
            {
                freqarr[i, 0] = c;
                freqarr[i, 1] = (int)freq[c];
                i++;
            }
            Sort(freqarr, 0, freq.Count - 1);
            Console.WriteLine("=================Sorted data=====================");
            for (i = 0; i < freq.Count; i++)
            {
                Console.Write($"[{(char)freqarr[i, 0]}]" + "=> "); 
                Console.WriteLine(freqarr[i, 1]);
            }

        }
        static void Sort(int[,] freq, int start, int end)
        {
            if (end <= start) return;
            int midpoint = (start + end) / 2;
            Sort(freq, start, midpoint);
            Sort(freq, midpoint + 1, end);
            Merge(freq, start, midpoint, end);
          
        }
        static void Merge(int[,] freq, int start, int midpoint, int end)
        {
            int i, j, k;
            int left_length = midpoint - start + 1;
            int right_length = end - midpoint;

            int[,] left_array =new int [left_length, 2];
            int[,] right_array=new int[right_length, 2];

            for(i=0; i < left_length; i++)
            {
                left_array[i, 0] = freq[start + i, 0];
                left_array[i, 1] = freq[start + i, 1];
            }

            for (j = 0; j < right_length; j++)
            {
                right_array[j, 0] = freq[midpoint + 1 + j, 0];
                right_array[j, 1] = freq[midpoint + 1 + j, 1];
            }

            i= 0;
            j = 0;
            k = start;
            while( i < left_length && j< right_length) 
            {
                if (left_array[i, 1] <= right_array[j, 1])// 1=> value
                {
                    freq[k, 0] = left_array[i, 0];
                    freq[k, 1] = left_array[i, 1];
                    i++;
                }
                else
                {
                    freq[k, 0] = right_array[j, 0];
                    freq[k, 1] = right_array[j, 1];
                    j++;
                }
                k++;
            }
            while (i < left_length)
            {
                freq[k, 0] = left_array[i, 0];
                freq[k, 1]= left_array[i, 1];
                i++;
                k++;
            }

            while(j< right_length)
            {
                freq[k,0]= right_array[j, 0];
                freq[k,1]= right_array[j, 1];
                j++;
                k++;
            }


        }

    }
}
