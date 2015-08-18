using System;

class DecimalToHexadecimal
{
    /*
        Problem 3. Decimal to hexadecimal

        Write a program to convert decimal numbers
        to their hexadecimal representation.
         
    */

    static void Main()
    {
        Console.Write("Enter Decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());
        string hexadecimalNum = "";
        int remainder = 0;
        while (decimalNum > 0)
        {
            remainder = decimalNum % 16;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10: hexadecimalNum += 'A';
                        break;
                    case 11: hexadecimalNum += 'B';
                        break;
                    case 12: hexadecimalNum += 'C';
                        break;
                    case 13: hexadecimalNum += 'D';
                        break;
                    case 14: hexadecimalNum += 'E';
                        break;
                    case 15: hexadecimalNum += 'F';
                        break;
                }
            }
            else
            {
                hexadecimalNum += remainder;
            }
            decimalNum = decimalNum / 16;

        }
        string result = "";
        for (int i = hexadecimalNum.Length - 1; i >= 0; i--)
        {
            result += hexadecimalNum[i];
        }
        Console.Write("number in hexadecimal is: ");
        Console.WriteLine(result);
    }
}

