using System;

class IsoscelesTriangle
{
    /*
         Isosceles Triangle

            Write a program that prints an isosceles triangle of 9 copyright 
            symbols ©, something like this:
                
                   ©
                
                  © ©
                
                 ©   ©
                
                © © © ©
      
            Note: The © symbol may be displayed incorrectly at the console 
            so you may need to change the console character encoding to UTF-8 
            and assign a Unicode-friendly font in the console.

            Note: Under old versions of Windows the © symbol may still be 
            displayed incorrectly, regardless of how much effort you put 
            to fix it.
    */

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char symbol = '\u00a9';
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                bool print = j == (4 - i + 1) || j == 4 + (4 - (4 - i + 1)) || (i == 4 && j % 2 != 0);
                if (print)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

