using System;
using System.Text;

class ReverseSentence
{
    /*
      13. Reverse sentence

    Write a program that reverses the words in given sentence.

        Example:
        input 	
        C# is not C++, not PHP and not Delphi! 	
        output
        Delphi not and PHP, not C++ not is C#!
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        string[] signs = text.Split(words, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder strB = new StringBuilder();
        int lastIndex = words.Length - 1;
        for (int i = 0; i < words.Length-1; i++)
        {
            if (signs[i] != " ")
            {
                strB.Append(words[lastIndex]);
                strB.Append(signs[i]);
            }
            else
            {
                if (lastIndex == words.Length - 1)
                {
                    words[lastIndex] = words[lastIndex].Replace
                        (words[lastIndex].Substring(0, 1), 
                        words[lastIndex].Substring(0, 1).ToUpper());
                }
                strB.Append(words[lastIndex]);
                strB.Append(" ");
            }
            lastIndex--;
        }
        strB.Append(words[0]);
        Console.WriteLine(strB.ToString());
    }
}

