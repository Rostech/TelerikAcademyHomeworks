using System;

class BinaryToDecimal
{
    /*
        Problem 2. Binary to decimal

        Write a program to convert binary numbers to their decimal representation.
     */
    static void Main()
    {
        Console.Write("Enter number in Binary: ");
        string number = Console.ReadLine();
        int decimalNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            decimalNum += ((char)number[i] - '0') * (int)(Math.Pow(2, number.Length - i - 1));

        }
        Console.Write("Number in Decimal is: ");
        Console.WriteLine(decimalNum);
    }
}

