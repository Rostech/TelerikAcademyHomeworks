using System;

class FibonacciNumbers
{
    /*
     10. Fibonacci Numbers

        Write a program that reads a number n and prints on the console 
        the first n members of the Fibonacci sequence (at a single line, 
        separated by comma and space - ,) :
        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

     */
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int fibNumber = 0;
        int fibNMinusOne = 0;
        int fibNMinusTwo = 1;
        for(int i = 1; i <= n; i++)
        {
            fibNumber = i == 2 ? 1 : fibNMinusOne + fibNMinusTwo;
            fibNumber = i == 1 ? 0 : fibNMinusOne + fibNMinusTwo;
            Console.Write(fibNumber + " ");
            fibNMinusOne = fibNMinusTwo;
            fibNMinusTwo = fibNumber;
        }
        Console.WriteLine();
    }
}

