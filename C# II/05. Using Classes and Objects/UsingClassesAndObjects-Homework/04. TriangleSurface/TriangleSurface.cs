using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        /*
             4. Triangle surface

             Write methods that calculate the surface of a triangle by given:
                 Side and an altitude to it;
                 Three sides;
                 Two sides and an angle between them;
             Use System.Math.

        */

        static double SideAndAltitude(double side, double altitude)
        {
            double result =  side * altitude *(1.0/2.0);
            return result;
        }

        static double ThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }

        static double TwoSidesAndTheAngle(double a, double b, double angle)
        {
            double result = (1.0 / 2.0) * (a * b * Math.Sin(angle));
            return result;
        }

        static void SurfaceOfTriangle(int n)
        {
            switch(n)
            {
                case 1:
                    Console.Write("Enter side's length: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Enter altitude's length: ");
                    double altitude = double.Parse(Console.ReadLine());
                    Console.Write("The triangles surface is: " + 
                    SideAndAltitude(side, altitude));
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Enter first side length: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter second side length: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter third side length: ");
                    double c = double.Parse(Console.ReadLine());
                    Console.Write("The triangles surface is: " + 
                    ThreeSides(a,b,c));
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Enter first side length: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter second side length: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Enter the angle between them: ");
                    double angle = double.Parse(Console.ReadLine());
                    Console.Write("The triangles surface is: " +
                    TwoSidesAndTheAngle(a, b, angle));
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Find triangle surface by:");
            Console.WriteLine("1. Side and an altitude to it.");
            Console.WriteLine("2. Three sides.");
            Console.WriteLine("3. Two sdes and an angle between them.");
            Console.Write("Choose method (1, 2 or 3) : ");
            int n = int.Parse(Console.ReadLine());
            SurfaceOfTriangle(n);
        }
    }
}
