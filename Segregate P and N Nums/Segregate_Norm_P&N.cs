using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregate_P_and_N_Nums
{
    /// <summary>
    /// Complexity==> O(N)
    /// </summary>
    public class Segregate_Norm_P_N
    {
        public static List<int> Segregate(List<int> array)
        {
            int i=0;
            List<int> P = new ();
            List<int> N = new ();
            while (i < array.Count)
            {
                if (array[i] > 0)
                {
                    P.Add(array[i]);
                    
                }
                else
                {
                    N.Add(array[i]);
                }
                i++;
            }
            N.AddRange(P);
            return N;
        }

    }
}
