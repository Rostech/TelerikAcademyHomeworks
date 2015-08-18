using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class OrderWords
{
    /*
     24. Order words

        Write a program that reads a list of words, separated by spaces 
        and prints the list in an alphabetical order.

    */
    static void Main()
    {
        Console.WriteLine("Enter a list of words separated by spaces: ");
        List<string> words = new List<string>();
        words = Console.ReadLine().Split(' ').ToList();
        string firstWord = string.Empty;
        StringBuilder finalResult = new StringBuilder();
        int lenghtOfList = words.Count;
        int lenght = 0;
        while (lenght < lenghtOfList)
        {
            string finalFirst = words[0];
            for (int i = 0; i < words.Count - 1; i++)
            {
                int result = String.Compare(words[i], words[i + 1]);
                if (result == -1)
                {
                    firstWord = String.Concat(firstWord, words[i]);
                }
                else
                {
                    firstWord = String.Concat(firstWord, words[i + 1]);
                }
                if (String.Compare(firstWord, finalFirst) == -1)
                {
                    finalFirst = firstWord;
                }
                firstWord = String.Empty;
            }
            finalResult.Append(finalFirst);
            finalResult.Append(" ");
            words.Remove(finalFirst);
            firstWord = String.Empty;
            lenght++;
        }
        Console.WriteLine("ordered words: ");
        Console.WriteLine(finalResult);
    }
}

