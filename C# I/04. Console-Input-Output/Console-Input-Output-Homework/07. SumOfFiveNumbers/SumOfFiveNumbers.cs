using System;

class SumOfFiveNumbers
{
    /*
      7. Sum of 5 Numbers

     Write a program that enters 5 numbers (given in a single line, 
     separated by a space), calculates and prints their sum.

     */

    static void Main()
    {
        Console.Write("Enter five numbers separated by space: ");
        string fiveNumbres = Console.ReadLine();
        string[] arrNumbers = fiveNumbres.Split(' '); // spliting the string by spaces
        while(arrNumbers.Length !=  5)
        {
            Console.WriteLine("You have not entered five numbers. Enter five numbers");
            fiveNumbres = Console.ReadLine();
            arrNumbers = fiveNumbres.Split(' ');
        }
        Console.WriteLine("result");
        double result = 0;
        for(int i = 0; i < 5; i++)
        {
            Console.Write(arrNumbers[i]);
            if( i < 4)
            {
                Console.Write(" + ");
            }
            result += Convert.ToDouble(arrNumbers[i]);
        }
        Console.Write(" = " + result);
        Console.WriteLine();
    }
}

