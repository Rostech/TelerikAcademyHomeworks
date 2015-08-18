using System;

class PrintLongSequence
{
    /* Problem 16.* Print Long Sequence

        Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
        You might need to learn how to use loops in C# (search in Internet). */

    static void Main()
    {
        for (int i = 1; i <= 1000; i += 2)
        {
            Console.Write(i + 1 + " ");
            Console.Write((-1) * (i + 2) + " ");
        }
        Console.WriteLine();
    }
}

