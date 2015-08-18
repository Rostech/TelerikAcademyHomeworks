using System;

class OneSystemToAnyOther
{
    /*
        Problem 7. One system to any other

        Write a program to convert from any numeral system
        of given base s to any other numeral system of base
        d (2 ≤ s, d ≤ 16).
        */
    static void Main()
    {
        Console.WriteLine("Make your choise");
        Console.WriteLine("1.Decima to binary");
        Console.WriteLine("2.Binary to Decimal");
        Console.WriteLine("3.Decimal to hexadecimal");
        Console.WriteLine("4.Hexadecimal to Decimal");
        Console.WriteLine("5.Binary to hexadecimal");
        Console.WriteLine("6.Hexadecimal to Binary");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1: DecimalToBinary();
                break;
            case 2: BinaryToDecimal();
                break;
            case 3: DecimalToHexadecimal();
                break;
            case 4: HexadecimalToDecimal();
                break;
            case 5: BinaryToHexadecimal();
                break;
            case 6: HexadecimalToBinary();
                break;
            default: Console.WriteLine("Wrong input!");
                break;
        }
    }
    static void DecimalToBinary()
    {
        Console.Write("The number int Decimal: ");
        int number = int.Parse(Console.ReadLine());
        int remainder = number;
        string NumInbinary = "";
        while (number > 0)
        {
            remainder = number % 2;
            NumInbinary += remainder;
            number = number / 2;
        }
        string result = "";
        for (int i = NumInbinary.Length - 1; i >= 0; i--)
        {
            result += NumInbinary[i];
        }
        Console.WriteLine("The number in Binary is: {0}", result);
    }
    static void BinaryToDecimal()
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
    static void DecimalToHexadecimal()
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
    static void HexadecimalToDecimal()
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
    static void HexadecimalToBinary()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        hexadecimal = hexadecimal.ToUpper();
        string binary = "";
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            switch (hexadecimal[i])
            {
                case '0': binary += "0000";
                    break;
                case '1': binary += "0001";
                    break;
                case '2': binary += "0010";
                    break;
                case '3': binary += "0011";
                    break;
                case '4': binary += "0100";
                    break;
                case '5': binary += "0101";
                    break;
                case '6': binary += "0110";
                    break;
                case '7': binary += "0111";
                    break;
                case '8': binary += "1000";
                    break;
                case '9': binary += "1001";
                    break;
                case 'A': binary += "1010";
                    break;
                case 'B': binary += "1011";
                    break;
                case 'C': binary += "1100";
                    break;
                case 'D': binary += "1101";
                    break;
                case 'E': binary += "1110";
                    break;
                case 'F': binary += "1111";
                    break;
            }
        }
        Console.Write("The number in Binary is: ");
        Console.WriteLine(binary);
    }
    static void BinaryToHexadecimal()
    {

        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        string four = "";
        string hexadecimal = "";
        string binaryRest = "";
        int ost = 0;
        if (binary.Length % 4 != 0)
        {
            ost = binary.Length % 4;
        }
        binary = binary.PadLeft(binary.Length + (4 - ost), '0');
        for (int i = 0; i < binary.Length - 3; i++)
        {
            for (int j = i; j <= i + 3; j++)
            {
                four += binary[j];
                binaryRest += binary[j];
            }
            switch (four)
            {
                case "0000": hexadecimal += "0";
                    break;
                case "0001": hexadecimal += "1";
                    break;
                case "0010": hexadecimal += "2";
                    break;
                case "0011": hexadecimal += "3";
                    break;
                case "0100": hexadecimal += "4";
                    break;
                case "0101": hexadecimal += "5";
                    break;
                case "0110": hexadecimal += "6";
                    break;
                case "0111": hexadecimal += "7";
                    break;
                case "1000": hexadecimal += "8";
                    break;
                case "1001": hexadecimal += "9";
                    break;
                case "1010": hexadecimal += "A";
                    break;
                case "1011": hexadecimal += "B";
                    break;
                case "1100": hexadecimal += "C";
                    break;
                case "1101": hexadecimal += "D";
                    break;
                case "1110": hexadecimal += "E";
                    break;
                case "1111": hexadecimal += "F";
                    break;
            }
            four = "";
            i = i + 3;
        }
        Console.Write("The number in hexadecimal is: ");
        Console.WriteLine(hexadecimal);
    }
}

