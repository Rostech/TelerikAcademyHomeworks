using System;

class ExchangeIfGreater
{
    /*
      1. Exchange If Greater

     Write an if-statement that takes two double variables a 
     and b and exchanges their values if the first one is greater 
     than the second one. As a result print the values a and b, 
     separated by a space.
    */

    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second numbre: ");
        double b = double.Parse(Console.ReadLine());
        if(a > b)
        {
            double c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("Result: {0} {1}", a, b);
    }
}

