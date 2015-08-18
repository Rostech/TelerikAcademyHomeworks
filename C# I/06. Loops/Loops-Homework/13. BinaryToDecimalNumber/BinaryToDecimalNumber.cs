using System;

class BinaryToDecimalNumber
{
    /*
     13. Binary to Decimal Number

        Using loops write a program that converts a binary integer 
        number to its decimal form.
        The input is entered as string. The output should be a 
        variable of type long.
        Do not use the built-in .NET functionality.

    */
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();
        // checking for corect input
        while(binary.Length > 32)
        {
            Console.WriteLine("Incorect input!");
            Console.Write("Enter a binary number: ");
            binary = Console.ReadLine();
        }
        bool incorectInput = false;
        do
        {
            incorectInput = false;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0' || binary[i] == '1')
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
                Console.Write("Enter a binary number: ");
                binary = Console.ReadLine();
            }
        } while (!incorectInput);
        // solving the task
        long numberToDecimal = 0;
        char[] binaryCharArray = binary.ToCharArray();
        Array.Reverse(binaryCharArray);
        for(int i = 0; i < binary.Length; i++)
        {
            numberToDecimal += ((int)binaryCharArray[i] - '0') * (int)Math.Pow(2, i);
        }
        Console.WriteLine("Result to decimal: " + numberToDecimal);

    }
}

