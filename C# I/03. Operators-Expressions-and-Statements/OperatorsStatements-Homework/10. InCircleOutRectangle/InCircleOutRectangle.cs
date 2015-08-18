using System;

namespace _10.InCircleOutRectangle
{
    class InCircleOutRectangle
    {
        /*
         *Point Inside a Circle & Outside of a Rectangle

            Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
            and out of the rectangle R(top=1, left=-1, width=6, height=2).

        */
        static void Main()
        {
            double[] x = { 1, 2.5, 0, 2.5, 2, 4, 2.5, 2, 1, -100 };
            double[] y = { 2, 2, 1, 1, 0, 0, 1.5, 1.5, 2.5, -100 };
            double[] pointA = {-1, 1}; // x, y
            double[] pointB = {5, 1};
            double[] pointC = {-1, -1};
            double[] pointD = {5, -1};
            byte pX = 0, pY = 1;
            for(int i = 0; i < x.Length; i++)
            {
                if(Math.Pow((x[i] - 1),2) + Math.Pow((y[i] - 1), 2) <= Math.Pow(1.5, 2))
                {
                    if(!(x[i] >= pointA[pX] && y[i] <= pointA[pY] && x[i] <= pointB[pX] &&
                        y[i] <= pointB[pY] && x[i] >= pointC[pX] && y[i] >= pointC[pY] &&
                        x[i] <= pointD[pX] && y[i] >= pointD[pY]))
                    {
                        Console.WriteLine("point({0}, {1}) is inside K and outside R ", x[i], y[i]);
                    }
                    else
                    {
                        Console.WriteLine("point({0}, {1}) is not inside K and outside R", x[i], y[i]);
                    }
                }
                else
                {
                    Console.WriteLine("point({0}, {1}) is not inside K and outside R", x[i], y[i]);
                }
            }
        }
    }
}
