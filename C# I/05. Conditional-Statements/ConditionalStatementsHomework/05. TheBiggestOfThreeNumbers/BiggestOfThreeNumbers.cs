using System;

class BiggestOfThreeNumbers
{
    /* 5. The Biggest of 3 Numbers

        Write a program that finds the biggest of three numbers. 
    */

    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        if (a >= b && a >= c)
        {
            Console.WriteLine("Biggest: " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Biggest: " + b);
        }
        else
        {
            Console.WriteLine("Biggest: " + c);
        }

    }
}

