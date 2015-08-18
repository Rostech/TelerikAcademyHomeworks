using System;

class BiggestOfFiveNumbers
{
    /*
      6. The Biggest of Five Numbers

        Write a program that finds the biggest of five 
        numbers by using only five if statements
    */
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter number d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter number e: ");
        double e = double.Parse(Console.ReadLine());
        double biggest = 0;
        if(a >= b && a >= b && a >= c && a >= d && a >= e)
        {
            biggest = a;
        }
        if (b >= a && b >= c && b >= d && b >= e)
        {
            biggest = b;
        }
        if (c >= a && c >= b && c >= d && c >= e)
        {
            biggest = c;
        }
        if (d >= a && d >= b && d >= c && d >= e)
        {
            biggest = d;
        }
        if (e >= a && e >= b && e >= c && e >= d)
        {
            biggest = e;
        }
        Console.WriteLine("Biggest: " + biggest);
        
    }
}

