using System;

class BinaryToHexadecimal
{
    /*
        Problem 6. Binary to hexadecimal

        Write a program to convert binary numbers to hexadecimal
        numbers (directly).
        */
    static void Main()
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

