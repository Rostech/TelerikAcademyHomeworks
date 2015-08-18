using System;

class DecimalToHexadecimalNumber
{
    /*
      16. Decimal to Hexadecimal Number

        Using loops write a program that converts an integer number to 
        its hexadecimal representation.
        The input is entered as long. The output should be a variable 
        of type string.
        Do not use the built-in .NET functionality.

    */
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string toDecimalNumber = "";
        string result = "";
        string hexadecimalSystem = "0123456789ABCDEF";
        while(decimalNumber > 15)
        {
            toDecimalNumber += hexadecimalSystem[(int)(decimalNumber % 16)];
            decimalNumber /= 16;
        }
        toDecimalNumber += hexadecimalSystem[(int)(decimalNumber % 16)];
        decimalNumber /= 16;
        for (int i = toDecimalNumber.Length-1; i >= 0; i--)
        {
            result += toDecimalNumber[i];
        }
        Console.WriteLine("The result to hexadecimal is: " + result);
    }
}

