using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        /* Rectangles

        Write an expression that calculates rectangle’s perimeter and area 
        by given width and height.
        */

        static void Main()
        {
            double[] width = { 3, 2.5, 5 };
            double[] height = { 4, 3, 5 };
            for(int i = 0; i < width.Length; i++)
            {
                Console.WriteLine("width: {0} height: {1} perimeter: {2} area: {3}",width[i], height[i], (2*width[i] + 2*height[i]), (width[i] * height[i]));
            }
        }
    }
}
