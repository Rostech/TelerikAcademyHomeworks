using System;

class PrintSequence
{
    /* Problem 9. Print a Sequence

        Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

    static void Main()
    {
        for (int i = 1; i <= 10; i+=2)
        {
            Console.Write(i + 1 + " ");
            Console.Write((-1)*(i + 2) + " ");
        }
        Console.WriteLine();
    }
}

