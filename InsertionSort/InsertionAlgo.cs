using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    /// <summary>
    /// Complexity==> O(n^2)
    /// </summary>
    
    public class InsertionAlgo
    {
        /// <summary>
        /// 1- unsorted=[],key=0,i,j;
        /// 2- read unsorted
        /// 3- for i=1, forward i< unsorted.Length
        ///   3.1- key=unsorted[i];
        ///   3.2- for j=i-1 backward j>=0
        ///      3.2.1- if key<unsorted[j] then unsorted[j+1]=unsorted[j]
        ///      3.2.2- else break this loop
        ///   3.3- unsorted[j+1]=key
        /// 4- return unsorted
        /// </summary>
        public static List<int> InsertionSort(List<int> unsorted)
        {
            int Key,j,i;
            for(i=1;i<unsorted.Count; i++)
            {
                Key = unsorted[i];
                for( j=i-1;j>=0; j--)
                {
                    if (Key < unsorted[j]) unsorted[j + 1] = unsorted[j];
                    else break;
                }
                unsorted[j + 1] = Key;

            }
            return unsorted;

        }
    }
}
