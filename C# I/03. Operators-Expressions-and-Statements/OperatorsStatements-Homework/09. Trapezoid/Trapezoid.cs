using System;

namespace _09.Trapezoid
{
    class Trapezoid
    {
        /*
          Trapezoids
            Write an expression that calculates trapezoid's area by given sides a and b and height h.
        */
        static void Main()
        {
            double[] a = { 5, 2, 8.5, 100, 0.222 };
            double[] b = { 7, 1, 4.3, 200, 0.333 };
            double[] h = { 12, 33, 2.7, 300, 0.555 };
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a: {0} b: {1} h:{2}  area = {3}",a[i],b[i],h[i], ((a[i]+b[i])/2)*h[i]);
            }
        }
    }
}
