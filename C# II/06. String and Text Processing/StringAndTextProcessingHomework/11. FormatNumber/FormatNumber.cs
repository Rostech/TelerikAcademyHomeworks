using System;

class FormatNumber
{
    /*
      11. Format number

        Write a program that reads a number and prints it as a decimal 
        number, hexadecimal number, percentage and in scientific notation.
        Format the output aligned right in 15 symbols.

    */
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("{0, -25} {1}","Decimal number: ", String.Format("{0:D}",(int)number));
        Console.WriteLine("{0, -25} {1}", "Hexadecimal number: ", String.Format("{0:X}", (int)number));
        Console.WriteLine("{0, -25} {1}", "Percentage: ", String.Format("{0:P}", number));
        Console.WriteLine("{0, -25} {1}", "Scientific notation: ", String.Format("{0:G}", number));
    }
}

