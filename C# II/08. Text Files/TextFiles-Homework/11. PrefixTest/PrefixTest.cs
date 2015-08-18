using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Collections.Generic;

class PrefixTest
{
    /*
     11. Prefix "test"

        Write a program that deletes from a text file all words that 
        start with the prefix test.
        Words contain only the symbols 0…9, a…z, A…Z, _.

    */
    static void Main(string[] args)
    {
        string path = @"..\..\..\Files\prefixTest11Taks.txt";
        try
        {
            StreamReader read = new StreamReader(path);
            StringBuilder strb = new StringBuilder();
            using (read)
            {
                string text = read.ReadToEnd();
                string[] words = text.Trim().Split(' ', '\n');
                string pattern = @"[0-9a-zA-Z_]*";
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i][0] != 't' && words[i][1] != 'e'
                        && words[i][2] != 's' && words[i][3] != 't')
                    {
                        Match match = Regex.Match(words[i], pattern);
                        if (match.Success)
                        {
                            strb.Append(words[i] + " ");
                        }
                    }
                }
            }
            File.WriteAllText(path, strb.ToString());
            Console.WriteLine("Success");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("An argument exception accured!");
        }
        catch(Exception)
        {
            Console.WriteLine("Oops something went wrong!");
        }
    }
}

