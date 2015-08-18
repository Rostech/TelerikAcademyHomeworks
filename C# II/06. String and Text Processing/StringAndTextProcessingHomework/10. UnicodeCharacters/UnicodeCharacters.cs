using System;
using System.Text;

class UnicodeCharacters
{
    /*
      10. Unicode characters

        Write a program that converts a string to a sequence of C# Unicode 
        character literals. Use format strings.

        Example:
        input 	output
        Hi! 	\u0048\u0069\u0021
    */
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        StringBuilder strB = new StringBuilder();
        for (int i = 0; i < text.Length; i++ )
        {
            strB.Append("\\u00" + String.Format("{0:X}",(int)text[i]));
        }
        Console.WriteLine("{0,-"+(text.Length+5)+"} {1}", "input", "output");
        Console.WriteLine("{0,-" + (text.Length + 5) + "} {1}", text, strB.ToString());
    }
}

