using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ForbidenWords
{
    class ForbidenWords
    {
        /*
         *  9. Forbidden words

        We are given a string containing a list of forbidden words and a 
        text containing some of these words.
        Write a program that replaces the forbidden words with asterisks.

        Example text: Microsoft announced its next generation PHP compiler 
        today. It is based on .NET Framework 4.0 and is implemented as a 
        dynamic language in CLR.
        
        Forbidden words: PHP, CLR, Microsoft
        
        The expected result: ********* announced its next generation *** 
        compiler today. It is based on .NET Framework 4.0 and is 
        implemented as a dynamic language in ***.
        
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Trim().Split();
            int index = 0;
            foreach(string forbiden in forbiddenWords)
            {
                index = 0;
                index = text.IndexOf(forbiden, index);
                while(index >= 0)
                {
                    text = text.Replace(text.Substring(index, forbiden.Length),
                        Convert.ToString("").PadRight(forbiden.Length, '*'));
                    index++;
                    index = text.IndexOf(forbiden, index);
                }
            }
            Console.WriteLine("Result: " + text);
        }
    }
}
