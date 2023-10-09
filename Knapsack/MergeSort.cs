using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    /// <summary>
    /// Complexit ==> O(n log n)
    /// </summary>
    public class MergeSortAlgo
    {
        public static void MergeSort(List<Item> unsorted, int start, int end)
        {
            if (start < end)
            {
                int midPoint = (start + end) / 2;
                MergeSort(unsorted, start, midPoint);
                MergeSort(unsorted, midPoint + 1, end);
                Merge(unsorted, midPoint, start, end);
            }
        }

        public static void Merge(List<Item> unsorted, int midpoint, int start, int end)
        {
            int i, j, k;

            int leftLength = midpoint - start + 1;
            int rightLength = end - midpoint;

            List<Item> left_array = new();
            List<Item> right_array = new();

            for (int m = 0; m < leftLength; m++)
            {
                left_array.Add(unsorted[start + m]);
            }

            for (int n = 0; n < rightLength; n++)
            {
                right_array.Add(unsorted[midpoint + 1 + n]);
            }

            i = 0;
            j = 0;
            k = start;
            while (i < left_array.Count && j < right_array.Count)
            {
                if (left_array[i].Ratio > right_array[j].Ratio)
                {
                    unsorted[k] = left_array[i];
                    i++;
                }
                else
                {
                    unsorted[k] = right_array[j];
                    j++;
                }
                k++;
            }

            while (i < left_array.Count)
            {
                unsorted[k] = left_array[i];
                i++;
                k++;
            }

            while (j < right_array.Count)
            {
                unsorted[k] = right_array[j];
                j++;
                k++;
            }
        }
    }
}
