using System;
using System.Text;

class BinaryShort
{

    static void ConverShortIntegerToBinary(int number)
    {
        StringBuilder result = new StringBuilder();
        if (number == 0)
        {
            Console.WriteLine("The number {0} converted to binary is: {1}", number, number);
            return;
        }
        int resNum = number;
        if (number >= 0)
        {
            while (number > 0)
            {
                result.Append((int)number % 2);
                number /= 2;
            }
            while (result.Length < 15)
            {
                result.Append('0');
            }
        }
        if(number < 0)
        {
            number = Math.Abs(number);
            number = (short)(Math.Pow(2,15)- number);
            Console.WriteLine(number);
            while (number > 0)
            {
                result.Append((int)number % 2);
                number /= 2;
            }
            while(result.Length < 15)
            {
                result.Append('0');
            }
        }
        StringBuilder reversed = new StringBuilder();
        reversed.Append(resNum > 0 ? '0' : '1');
        for (int i = 0; i < result.Length; i++)
        {
            reversed.Append(result[result.Length - 1 - i]);
        }
        Console.WriteLine("The number {0} converted to binary is: {1}", resNum, reversed.ToString());
    }

    static void Main()
    {
        Console.WriteLine("Enter an integer number from type short (-32 768 through 32 767):");
        int number = int.Parse(Console.ReadLine());
        ConverShortIntegerToBinary(number);
    }
}

