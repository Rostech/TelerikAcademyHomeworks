using System;
using System.Text;

class ReverseString
{
    /*
        2. Reverse string

            Write a program that reads a string, reverses it and prints 
            the result at the console.

        Example:
        input 	output
        sample 	elpmas
    */
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        StringBuilder reversedStrb = new StringBuilder();
        for(int i = input.Length-1; i >= 0; i--)
        {
            reversedStrb.Append(input[i]);
        }
        Console.WriteLine("Input: " + input + "  Reversed: " + reversedStrb.ToString());
    }
}

