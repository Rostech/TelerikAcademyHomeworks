using System;

class CalculateGCD
{
    /*
      17.* Calculate GCD

        Write a program that calculates the greatest common divisor 
        (GCD) of given two integers a and b.
        Use the Euclidean algorithm (find it in Internet).

    */
    static void Main()
    {
        Console.WriteLine("Calculate GCD");
        Console.Write("Enter number a: " );
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Using the Euclicean algorithm");
        Console.Write("GCD({0},{1}) = ",a,b);
        if(a < b)
        {
            int change = a;
            a = b;
            b = change;
        }
        int reminder = a % b;
        a = b;
        b = reminder;
        if (reminder > 0)
        {
            while (a % reminder > 0)
            {
                reminder = a % reminder;
                a = b;
                b = reminder;
            }
        }
        else
        {
            reminder = a;
        }
        Console.Write(reminder + "\n");
    }
}

