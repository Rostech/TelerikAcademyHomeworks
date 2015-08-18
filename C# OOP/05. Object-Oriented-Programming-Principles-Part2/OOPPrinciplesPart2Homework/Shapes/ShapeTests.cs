
namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Shapes.Models;

    class ShapeTests
    {
        /*
         1. Shapes

            Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
            Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
            (heightwidth for rectangle and heightwidth/2 for triangle).
            Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement
            the CalculateSurface() method.
            Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.

        */
        static void Main()
        {
            var arrWithShapes = new Shape[]
            {
                new Triangle(3,4),
                new Triangle(6,5),
                new Rectangle(3,4),
                new Rectangle(6,5),
                new Square(4),
                new Square(8),
            };

            foreach (var item in arrWithShapes)
            {
                Console.WriteLine(" {0} is the surface of a {1}({2})", item.CalculateSurface(), 
                    item.GetType().Name, 
                    item.GetType().Name.CompareTo("Square") != 0 ? item.Width.ToString() + ", " + item.Height.ToString() : item.Width.ToString() );
            }
        }
    }
}
