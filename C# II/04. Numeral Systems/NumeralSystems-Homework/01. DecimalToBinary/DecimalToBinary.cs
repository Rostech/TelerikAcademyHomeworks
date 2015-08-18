using System;
using System.Text;

class DecimalToBinary
{

    static void ConverDecimalToBinary(int number)
    {
        StringBuilder result = new StringBuilder();
        if(number == 0)
        {
            Console.WriteLine("The number {0} converted to binary is: {1}", number, number);
            return;
        }
        int resNum = number;
        if(number >= 0)
        {
            while(number > 0)
            {
                result.Append((int)number % 2);
                number /= 2;
            }
        }
        StringBuilder reversed = new StringBuilder();
        for (int i = 0; i < result.Length; i++)
        {
            reversed.Append(result[result.Length - 1 - i]);
        }
        Console.WriteLine("The number {0} converted to binary is: {1}",resNum, reversed.ToString());
    }

    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        ConverDecimalToBinary(number);
    }
}

