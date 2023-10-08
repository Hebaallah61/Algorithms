using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    /// <summary>
    /// Complexity==> O(log n)
    /// </summary>
    public class BinaryAlgo
    {
        ///<summary> 
        /// 0- read sorted, key
        /// 1- Calculate mid based on low and high
        /// 2- if key== sorted[mid] return mid
        /// 3- else if key > sorted[mid] then
        ///   3.1- move low after mid
        /// 4- else
        ///    4.1- move high before mid
        /// 5- repeat until key== sorted[mid]
        /// </summary>
        public static int BinarySearch(List<int> sorted,int key)
        {
            int low=0,high=sorted.Count()-1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (key == sorted[mid]) return mid;
                else
                {
                    if (key > sorted[mid]) low = mid + 1;
                    else high = mid - 1;
                }
            }
            return -1;
        }
    }
}
