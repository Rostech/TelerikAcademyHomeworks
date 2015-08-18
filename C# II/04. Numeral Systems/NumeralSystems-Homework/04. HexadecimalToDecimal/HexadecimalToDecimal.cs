using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        int decimalNum = 0;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if ((char)hexadecimal[i] - '0' <= 9)
            {
                decimalNum += ((char)hexadecimal[i] - '0') * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
            }
            else
            {
                switch (hexadecimal[i])
                {
                    case 'A': decimalNum += 10 * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
                        break;
                    case 'B': decimalNum += 11 * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
                        break;
                    case 'C': decimalNum += 12 * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
                        break;
                    case 'D': decimalNum += 13 * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
                        break;
                    case 'E': decimalNum += 14 * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
                        break;
                    case 'F': decimalNum += 15 * (int)Math.Pow(16, (hexadecimal.Length - i - 1));
                        break;
                }
            }
        }
        Console.Write("The number in decimal is: ");
        Console.WriteLine(decimalNum);
    }

}

