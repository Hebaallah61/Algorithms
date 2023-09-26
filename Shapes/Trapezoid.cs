using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Trapezoid
    {
        /*
         1-Read B1, B2, H
         2-A=0.5*(B1+B2)*H
         3-return A       
         */
        public float B1 { get; set; }
        public float B2 { get; set; }
        public float H { get; set; }

        public Trapezoid()
        {
            
        }
        public Trapezoid(float b1, float b2, float h)
        {
            B1 = b1;
            B2 = b2;
            H = h;
        }

        public float Area(float b1, float b2, float h) {
        
            return (float)0.5 *(b1 + b2)*h;
        }
    }
}
