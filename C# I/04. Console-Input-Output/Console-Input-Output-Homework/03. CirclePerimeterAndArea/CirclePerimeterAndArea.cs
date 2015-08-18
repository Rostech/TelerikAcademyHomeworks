using System;

class CirclePerimeterAndArea
{
    /*
     3. Circle Perimeter and Area

        Write a program that reads the radius r of a circle and prints 
        its perimeter and area formatted with 2 digits after the decimal 
        point.

     */
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter = {0:0.00}      Radius = {1:0.00}",2*(Math.PI*radius), Math.PI*Math.Pow(radius,2));
    }
}

