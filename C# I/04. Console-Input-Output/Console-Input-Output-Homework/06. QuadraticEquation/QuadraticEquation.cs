using System;

class QuadraticEquation
{
    /* 6. Quadratic Equation

    Write a program that reads the coefficients a, b and c of a quadratic 
    equation ax2 + bx + c = 0 and solves it (prints its real roots).
    */

    static void Main()
    {
        Console.Title = "Quadratic Quation";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The quadratic equation is:   {0}x^2 + {1}x + {2} = 0", a, b, c);

        double discriminant = (b * b) - (4 * (a * c));
        if(discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if(discriminant == 0)
        {
            double oneRoot = (b * (-1)) / (2 * a);
            Console.WriteLine("The eqiation has only one root. x1 = x2 = " + oneRoot);
        }
        else
        {
            double x1 = ((b * (-1)) - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = ((b * (-1)) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The roots are:   x1 = {0} x2 = {1}",x1,x2);
        }
    }
}

