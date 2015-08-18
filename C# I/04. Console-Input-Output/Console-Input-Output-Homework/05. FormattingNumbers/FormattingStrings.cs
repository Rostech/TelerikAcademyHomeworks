using System;

class FormattingStrings
{
    /*
     * 5. Formatting Numbers

        - Write a program that reads 3 numbers:
            - integer a (0 <= a <= 500)
            - floating-point b
            - floating-point c
        - The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            - The number a should be printed in hexadecimal, left aligned
            - Then the number a should be printed in binary form, padded with zeroes
            - The number b should be printed with 2 digits after the decimal point, right aligned
            - The number c should be printed with 3 digits after the decimal point, left aligned.

     */
    static void Main()
    {
        //input
        Console.Title = "Formatting Numbers";
        Console.Write("Enter an integer number a = ");
        ushort a = ushort.Parse(Console.ReadLine());
        Console.Write("Enter a floating-point number b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a floating-point numbre c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine();
        //formating text
        string outputA = "{0,-10}";
        string outputAToBinary = "{0}";
        string outputB = b % 1 == 0 ? "{0,10}" : "{0,10:0.00}";
        string outputC = "{0,-10:0.000}";
        //output
        Console.Write(outputA, a.ToString("X"));
        Console.Write("|"+outputAToBinary, Convert.ToString(a,2).PadLeft(10,'0') + "|");
        Console.Write(outputB, b);
        Console.Write("|");
        Console.Write(outputC, c);
        Console.Write("|");
        Console.WriteLine();

    }
}


