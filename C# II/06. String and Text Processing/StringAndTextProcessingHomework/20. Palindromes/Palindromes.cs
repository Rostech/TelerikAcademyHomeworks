using System;
using System.Collections.Generic;

class Palindromes
{
    /*
     20. Palindromes

     Write a program that extracts from a given text all palindromes, 
     e.g. ABBA, lamal, exe.

    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] {' ',',','.'},StringSplitOptions.RemoveEmptyEntries);
        List<string> polindromes = new List<string>();
        foreach(string word in words)
        {
            bool polindrome = true;
            for(int i = 0; i < word.Length/2; i++)
            {
                if(word[i] != word[word.Length-1-i])
                {
                    polindrome = false;
                    break;
                }
            }
            if(polindrome)
            {
                polindromes.Add(word);
            }
        }
        Console.WriteLine("{0}", polindromes.Count == 0 ? "There are no polindomes!" : "The polindromes are: " + string.Join(",", polindromes));
    }
}

