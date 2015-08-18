using System;

class SumOf3Numbers
{
    /*
       Sum of 3 Numbers

        Write a program that reads 3 real numbers from the console and 
        prints their sum.
    */
    static void Main()
    {
        Console.Title = "Sum of 3 Numbers"; // changes the title of the console application
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,a + b + c );
    }
}

