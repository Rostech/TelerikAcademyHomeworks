using System;

class DecimalToBinaryNumber
{
    /*
     14. Decimal to Binary Number

        Using loops write a program that converts an integer number 
        to its binary representation.
        The input is entered as long. The output should be a variable 
        of type string.
        Do not use the built-in .NET functionality.

    */
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long number = long.Parse(Console.ReadLine());
        string result = "";
        while(number / 2 >= 1)
        {
            result += number % 2;
            number /= 2;
        }
        result += number;
        string binary = "";
        for (int i = result.Length - 1; i >= 0;i-- )
        {
            binary += result[i];
        }
        Console.WriteLine("Binary result is: " + binary);

    }
}

