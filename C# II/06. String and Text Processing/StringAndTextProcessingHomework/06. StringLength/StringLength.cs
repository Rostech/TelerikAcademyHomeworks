using System;

class StringLength
{
    /*
        6. String length

        Write a program that reads from the console a string of 
        maximum 20 characters. If the length of the string is less 
        than 20, the rest of the characters should be filled with *.
        Print the result string into the console.

    */
    static void Main()
    {
        Console.WriteLine("Enter string with maximum 20 chars: ");
        string input = Console.ReadLine();
        if(input.Length > 20)
        {
            Console.WriteLine("The string is too long!");
            return;
        }
        Console.WriteLine("Result: " + input.PadRight(20, '*'));
    }
}

