using System;
using System.Text;
using System.Collections.Generic;

class LettersCount
{
    /*
     21. Letters count

        Write a program that reads a string from the console and 
        prints all different letters in the string along with 
        information how many times each letter is found.

    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();
        StringBuilder strB = new StringBuilder(word);
        Dictionary<char, int> result = new Dictionary<char, int>();
        for(int i = 0; i < strB.Length; i++)
        {
            int count = 1;
            for(int j = i+1; j < strB.Length; j++)
            {
                if(strB[i]== strB[j])
                {
                    count++;
                    strB.Remove(j, 1);
                    j--;
                }
            }
            result.Add(strB[i], count);
        }
        for(int i = 0; i < strB.Length; i++)
        {
            Console.WriteLine("{0} - {1} {2}",strB[i], result[strB[i]], result[strB[i]] > 1 ? "times" : "time");
        }
    }
}

