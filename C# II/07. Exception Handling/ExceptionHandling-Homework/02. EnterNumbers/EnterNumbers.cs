using System;
using System.Collections.Generic;

class EnterNumbers
{
    /*
     2. Enter numbers

        Write a method ReadNumber(int start, int end) that enters an 
        integer number in a given range [start…end].
            If an invalid number or non-number text is entered, the 
            method should throw an exception.
        Using this method write a program that enters 10 numbers: a1, 
        a2, … a10, such that 1 < a1 < … < a10 < 100

    */


    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number in range ({0}, {1}): ",start,end);
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                Exception ex = new Exception();
                throw ex;
            }
        }
        catch
        {
            Console.WriteLine("Wrong number!");
            return -1;
        }
        return number;
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        int number = 0;
        Console.WriteLine("Numbers should be 1 < a1 < ... < a10 < 100");
        for(int i = 1; i <= 10; i++)
        {
            number = ReadNumber(1, 100);
            while(number <= numbers[i-1])
            {
                Console.WriteLine("Enter number bigger than the previous ({0}): ", numbers[i-1]);
                number = ReadNumber(1, 100);
            }
            numbers.Add(number);
        }
        numbers.RemoveAt(0);
        Console.WriteLine("The numbers are: " + string.Join(" < ",numbers));
    }
}

