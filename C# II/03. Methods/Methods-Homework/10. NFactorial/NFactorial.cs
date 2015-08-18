using System;
using System.Numerics;

class NFactorial
{
    /*
      10. N Factorial

        Write a program to calculate n! for each n in the range [1..100].

        Hint: Implement first a method that multiplies a number represented
        as array of digits by given integer number.
    */

    static BigInteger Factorial(int i)
    {
        if(i == 0)
        {
            return 1;
        }
        return i * Factorial(i - 1);
    }

    static void Main()
    {
        BigInteger p = Factorial(10000);
        Console.WriteLine(p);
    }
}

