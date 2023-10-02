using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregate_P_and_N_Nums
{
    /// <summary>
    /// 
    /// </summary>
    public class Segregate_P_N
    {
        /// <summary> --->MergeSort
        /// 1- Read the array(x), Start, End index of the portion that we need to sort
        /// 2- Don't continue if End >= Start
        /// 3- Calculate the MidPoint= (Start+End)/2
        /// 4- Divide the portion of the array into New two arrays 
        /// 5- Call yourself twice, one for the left portion, the other for the right portion 
        /// 6- Merge the two portions 
        /// </summary>
        public static void MergeSort(List<int> unsorted, int start, int end)
        {

            List<int> arr1 = new();
            List<int> arr2 = new();
            if (start < end)
            {
                int midPoint = (start + end) / 2;
                MergeSort(unsorted, start, midPoint);
                MergeSort(unsorted, midPoint + 1, end);
                Merge(unsorted, midPoint, start, end);
            }
        }

        ///<summary> --->Merge
        /// 1- Read the array(x), MidPoint, Start, End index
        /// 2- Create two new arrays for each side
        ///   2.1- define the length of each subarray
        ///   2.2- create two empty subarrays based on calculated length
        ///   2.3- loop from start index to midpoint to fill the left subarray
        ///   2.4- loop from the midpoint+1 to end index to fill the right subarray
        /// 3- Compare all items in the array & sort it in the original array
        ///   3.1- loop over the left subarray
        ///      3.1.1- if current item<0 then add it to the main array and increase its counter
        ///   3.2- loop over the right subarray
        ///      3.2.1- if current item<0 then add it to the main array and increase its counter
        /// 4- Move remain items in each array to the original array as it
        /// </summary>
        public static void Merge(List<int> unsorted, int midpoint, int start, int end)
        {
            int i, j, k;

            int leftLength = midpoint - start + 1;
            int rightLength = end - midpoint;

            List<int> left_array = new();
            List<int> right_array = new();

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
            while (i<leftLength && left_array[i]<0)
            {               
               unsorted[k] = left_array[i];
               i++;
               k++;
            }
            while (j<rightLength && right_array[j] < 0)
            {
                unsorted[k] = right_array[j];
                j++;
                k++;
            }

            ///<summary>
            /// for the remaining sorted items only one loop while run
            ///</summary>
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
