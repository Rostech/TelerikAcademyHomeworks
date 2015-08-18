using System;

class TrailingZeroesInNFactorial
{
    /*
      18.* Trailing Zeroes in N!

        Write a program that calculates with how many zeroes the factorial 
        of a given number n has at its end.
        Your program should work well for very big numbers, e.g. n=100000.

    */
    static void Main()
    {
        Console.Write("Enter number: ");
        ulong number = ulong.Parse(Console.ReadLine());
        Console.Write("The zeros in {0}! are: ", number);
        ulong devide = 5;
        ulong result = 0;
        result += number / devide;
        ulong counter = 2;
        while (number / (ulong)Math.Pow(devide, counter) > 0)
        {
            result += number / (ulong)Math.Pow(devide, counter);
            counter++;
        }
        Console.WriteLine(result);
    }
}

