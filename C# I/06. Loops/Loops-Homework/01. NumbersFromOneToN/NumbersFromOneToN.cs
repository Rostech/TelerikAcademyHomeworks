using System;

class NumbersFromOneToN
{
    /*
      1. Numbers from 1 to N

        Write a program that enters from the console a positive integer 
        n and prints all the numbers from 1 to n, on a single line, 
        separated by a space.
    */

    static void Main()
    {
        int number;
        string strNumber;
        Console.Write("Enter number N: ");
        strNumber = Console.ReadLine();
        if (!int.TryParse(strNumber, out number) || number < 1)
        {
            Console.WriteLine("Incorect input!");
        }
        else
        {
            for(int i = 1; i<= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

