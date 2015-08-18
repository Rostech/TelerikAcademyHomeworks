using System;
using System.Text;

class ReverseNumber
{
    /*
      7. Reverse number

        Write a method that reverses the digits of given decimal number.
        example: 
        input 256 output 652
    */

    static decimal ReverseNumberMethod(decimal number)
    {
        StringBuilder numberToString = new StringBuilder(number.ToString());
        Console.WriteLine(numberToString.ToString());
        char change = ' ';
        for(int i = 0; i < numberToString.Length/2; i++)
        {
            change = numberToString[i];
            numberToString[i] = numberToString[numberToString.Length - 1 - i];
            numberToString[numberToString.Length - 1 - i] = change;
        }
        return Convert.ToDecimal(numberToString.ToString());
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal inputNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The reversed number  is: " + ReverseNumberMethod(inputNumber));
    }
}

