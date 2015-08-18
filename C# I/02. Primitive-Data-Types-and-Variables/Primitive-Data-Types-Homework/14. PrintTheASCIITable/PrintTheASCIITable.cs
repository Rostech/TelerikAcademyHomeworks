using System;

class PrintTheASCIITable
{
    /*
        Print the ASCII Table

        Find online more information about ASCII (American Standard 
        Code for Information Interchange) and write a program that 
        prints the entire ASCII table of characters on the console 
        (characters from 0 to 255).
    */

    static void Main()
    {
        char ch = ' ';
        for(int i = 1; i <= 255; i++)
        {
            if (i >= 7 && i <= 13)
                continue;
            ch = (char)i;
            Console.Write(ch + " ");
        }
        Console.WriteLine();
    }
}

