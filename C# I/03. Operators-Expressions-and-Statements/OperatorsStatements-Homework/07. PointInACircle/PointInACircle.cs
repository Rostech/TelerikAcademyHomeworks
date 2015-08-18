using System;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        /*
           Point in a Circle

             Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)
        */
        static void Main()
        {
            double[] x = { 0, -2, -1, 1.5, -1.5, 100, 0, 0.2, 0.9, 1 };
            double[] y = { 1, 0, 2, -1, -1.5, -30, 0, -0.8, -1.93, 1.655 };
            for(int i = 0; i < x.Length; i++)
            {
                //Console.WriteLine("masda = " + Math.Abs(x[i]));
                if(Math.Pow(Math.Abs(x[i]), 2) + Math.Pow(Math.Abs(y[i]),2) <= 4)
                {
                    Console.WriteLine("x: {0}  y: {1}  inside: true",x[i],y[i]);
                }
                else
                {
                    Console.WriteLine("x: {0}  y: {1}  inside: false", x[i], y[i]);
                }
            }
        }
    }
}
