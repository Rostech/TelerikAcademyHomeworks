using System;

class MatrixOfNumbers
{
    /*
      9. Matrix of Numbers

        Write a program that reads from the console a positive 
        integer number n (1 = n = 20) and prints a matrix like in 
        the examples below. Use two nested loops.

    */
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The result matrix is");
        for(int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            for(int j = 1; j < n; j++)
            {
                Console.Write(j+i + " ");
            }
            Console.WriteLine();
        }
    }
}

