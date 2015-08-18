using System;
using System.Text;
using System.Collections.Generic;

class WordsCount
{
    /*
        22. Words count

        Write a program that reads a string from the console and 
        lists all different words in the string along with information 
        how many times each word is found.

    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words separated by spaces: ");
        string[] arr = Console.ReadLine().Split();
        List<string> list = new List<string>(arr);
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i < list.Count; i++)
        {
            int count = 1;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    count++;
                    list.Remove(list[j]);
                    j--;
                }
            }
            result.Add(list[i], count);
        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("{0} - {1} {2}", list[i], result[list[i]], result[list[i]] > 1 ? "times" : "time");
        }
    }
}

