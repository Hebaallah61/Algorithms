using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Parallelogram
    {
        /*
         1- Read R1, R2
         2- Calculate A=(R1 * R2)÷2
         3- return A
         */
        public float R1 { get; set; }
        public float R2 { get; set; }
        public Parallelogram()
        {
            
        }

        public Parallelogram(float r1, float r2)
        {
            R1 = r1;
            R2 = r2;
        }

        public float Area(float x, float y)
        {
            return (x*y)/2;
        }
    }
}
