using System;

class NumbersNotDivisibleBy3and7
{
    /*
      2. Numbers Not Divisible by 3 and 7

        Write a program that enters from the console a positive 
        integer n and prints all the numbers from 1 to n not 
        divisible by 3 and 7, on a single line, separated by a space.

    */
    static void Main()
    {
        int numberN;
        string strNumberN;
        Console.Write("Enter number: ");
        strNumberN = Console.ReadLine();
        if(!int.TryParse(strNumberN, out numberN) || numberN < 0)
        {
            Console.WriteLine("Incorect input!");
        }
        else
        {
            for(int i = 1; i <= numberN; i++)
            {
                if(i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

