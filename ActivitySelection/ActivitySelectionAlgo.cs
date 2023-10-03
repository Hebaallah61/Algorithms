using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySelection
{
    /// <summary>
    /// Complexity ==> O(N) if sorted
    /// if not sorted we will use Merge Sort so==>O(NlogN)
    /// </summary>
    public class ActivitySelectionAlgo
    {
        ///<summary>
        /// 1- read start, End arrays
        /// 2- result array 
        /// 3- add activity 0 by default to result
        /// 4- i is index for start array=1
        /// 5- j is index for end array=0
        /// 6- loop from i to start array length
        ///   6.1- if start[i]>= end[j] then
        ///      6.1.1- add i to result 
        ///      6.1.2- j=i
        /// 7- return result
        /// </summary>
        public static List<int> ActivitySelection(List<int> start, List<int> end)
        {
            List<int> result = new ();
            int i, j=0;
            result.Add(0);
            for(i=1; i < start.Count ; i++)
            {
                if (start[i] >= end[j])
                {
                    result.Add(i);
                    j=i;
                }
            }
            return result;
        }
    }
}
