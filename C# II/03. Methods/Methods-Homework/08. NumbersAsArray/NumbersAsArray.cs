using System;
using System.Collections.Generic;

class NumbersAsArray
{
    /*
      8. Number as array

        Write a method that adds two positive integer numbers represented 
        as arrays of digits (each array element arr[i] contains a digit; 
        the last digit is kept in arr[0]).
        Each of the numbers that will be added could have up to 10 000 
        digits.

    */

    static int[] ReverseNumber(string number)
    {
        int[] arrNumber = new int[number.Length];
        for(int i = 0; i < number.Length; i++)
        {
            arrNumber[i] = number[number.Length - 1 - i] - '0';
        }
        return arrNumber;
    }

    static int[] AddNumbers(int[] firstNumber, int[] secondNumber)
    {
        List<int> result = new List<int>();
        int addition = firstNumber[0] + secondNumber [0];
        result.Add(addition % 10);
        for(int i = 1; i < firstNumber.Length; i++)
        {
            addition = (firstNumber[i] + secondNumber[i]) + addition / 10;
            result.Add(addition % 10);
        }
        if(addition / 10 > 0)
        {
            result.Add(addition / 10);
        }
        result.Reverse();
        return result.ToArray();
    }

    static void Main()
    {
        Console.WriteLine("Enter TWO POSITIVE numbers separated by SPACE: ");
        string[] input = Console.ReadLine().Split();
        if (input[0].Length < input[1].Length)
        {
            input[0] = input[0].PadLeft(input[1].Length, '0');
        }
        if (input[1].Length < input[0].Length)
        {
            input[1] = input[1].PadLeft(input[0].Length, '0');
        }
        Console.WriteLine("Your result is: " + string.Join("",
            AddNumbers(ReverseNumber(input[0]), ReverseNumber(input[1]))));
        
    }
}

