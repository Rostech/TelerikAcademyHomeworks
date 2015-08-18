using System;

class HexadecimalToDecimalNumber
{
    /*
     * 15. Hexadecimal to Decimal Number

        Using loops write a program that converts a hexadecimal integer 
        number to its decimal form.
        The input is entered as string. The output should be a variable 
        of type long.
        Do not use the built-in .NET functionality.

     */
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        string hexadecimalNumeralSystem = "0123456789ABCDEF";
        bool incorectInput = false;
        do
        {
            incorectInput = false;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if ((hexadecimal[i] >= '0' && hexadecimal[i] <= '9') ||
                    (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F'))
                {
                    incorectInput = true;
                }
                else
                {
                    incorectInput = false;
                    break;
                }
            }
            if (!incorectInput)
            {
                Console.WriteLine("Incorect input!");
                Console.Write("Enter a hexadecimal number: ");
                hexadecimal = Console.ReadLine();
            }
        } while (!incorectInput);
        long result = 0;
        int power = hexadecimal.Length - 1;
        for(int i = 0; i< hexadecimal.Length; i++)
        {
            int index = 0;
            for(int j = 0; j <hexadecimalNumeralSystem.Length; j++)
            {
                if(hexadecimal[i] == hexadecimalNumeralSystem[j])
                {
                    index = j;
                    break;
                }
            }
            result += index * (long)Math.Pow(16, power);
            power--;
        }
        Console.WriteLine("The result to decimal is: " + result);
    }
}

