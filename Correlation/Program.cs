namespace Correlation
{
    /*
     1-declare x[],y[], n, xSum, ySum, xPowSum, yPowSum, xySum, a, b, c, r, nchar
     2-read n,x[],y[]
     3-Calculate xSum= Sum(x), xPowSum= Sum(x^2)
     4-Calculate ySum= Sum(y), yPowSum= Sum(y^2)
     5-Calculate xySum= Sum(x*y)
     6-Calculate a= n*(xySum)- [Sum(x)*Sum(y)]
     7-Calculate b= sqrt(n* xPowSum - (xSum)^2)
     8-Calculate c= sqrt(n* yPowSum - (ySum)^2)
     9-Calculate r= a/(b*c)    
     */
    //n=12
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0,r=0, xSum = 0, ySum = 0, xPowSum = 0, yPowSum = 0, xySum = 0;
            int n = 0;
            string nchar;
          
            Console.WriteLine("Enter N size of Arrays");
            nchar=Console.ReadLine();
            if(int.TryParse(nchar, out n) && n > 0)
            {
                float[] x = new float[n];
                float[] y = new float[n];
                for ( int i = 0; i < n; i++ )
                {
                    Console.WriteLine($"Enter x[{i}]: ");
                    x[i] = float.Parse(Console.ReadLine());
                    xSum += x[i];
                    xPowSum += (Math.Pow(x[i], 2));
                    Console.WriteLine($"Enter y[{i}]: ");
                    y[i]= float.Parse(Console.ReadLine());
                    ySum += y[i];
                    yPowSum += (Math.Pow(y[i], 2));
                    xySum += (x[i] * y[i]);
                }
            }

            a = n * (xySum) - (xSum * ySum);
            b = Math.Sqrt(n* xPowSum - (Math.Pow(xSum, 2)));
            c = Math.Sqrt(n* yPowSum - (Math.Pow(ySum, 2)));
            
            if (b != 0 && c != 0)
            {
                r = a / (b * c);
                Console.WriteLine($"Correlation Coefficient (r): {r}");
            }
            else
            {
                Console.WriteLine(" Canot to calculate r.");
            }
        }
    }
}