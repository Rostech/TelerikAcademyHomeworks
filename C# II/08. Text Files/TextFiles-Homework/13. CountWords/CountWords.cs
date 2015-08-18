using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountWords
{
    /*
     13. Count words

        - Write a program that reads a list of words from the file 
        words.txt and finds how many times each of the words is 
        contained in another file test.txt.
        - The result should be written in the file result.txt and the 
        words should be sorted by the number of their occurrences in 
        descending order.
        - Handle all possible exceptions in your methods.

    */

    static string OpenFile(string path)
    {
        try
        {
            string result = string.Empty;
            StreamReader read = new StreamReader(path);
            using (read)
            {
                result = read.ReadToEnd();
            }
            return result;
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Not a valid arguments!");
            return null;
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File not found!");
            return null;
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
            return null;
        }
        catch(IOException)
        {
            Console.WriteLine("I/O error!");
            return null;
        }
        catch(Exception)
        {
            Console.WriteLine("Oops. Something went wrong!");
            return null;
        }
    }

    static void WriteToFile(string path, string text)
    {
        try
        {
            StreamWriter write = new StreamWriter(path);
            using (write)
            {
                write.WriteLine(text);
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Not a valid arguments!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }
        catch (IOException)
        {
        }
        catch (Exception)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }

    static void WriteToFile(string path, string[] text)
    {
        try
        {
            StreamWriter write = new StreamWriter(path);
            using (write)
            {
                foreach (string line in text)
                {
                    write.WriteLine(line);
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Not a valid arguments!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }
        catch (IOException)
        {
        }
        catch (Exception)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }

    static void CountTheWords(string pathToFile, string pathToFileWordList, string writeToPath)
    {
        try
        {
            string[] text = OpenFile(pathToFile).Trim().Split(' ', '\n', '\t', '\r');
            string[] words = OpenFile(pathToFileWordList).Trim().Split(' ', '\n', '\t', '\r');
            // count +=2 !
            Dictionary<string, int> wordsCountArr = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i += 2)
            {
                int count = 0;
                for (int j = 0; j < text.Length; j += 2)
                {
                    if (String.Compare(words[i], text[j], false) == 0)
                        count++;
                }
                wordsCountArr.Add(words[i], count);
            }
            List<KeyValuePair<string, int>> myList = wordsCountArr.ToList();
            myList.Sort
            (delegate(KeyValuePair<string, int> firstPair,
                KeyValuePair<string, int> nextPair)
                {
                    return firstPair.Value.CompareTo(nextPair.Value);
                }
            );
            StringBuilder strB = new StringBuilder();
            for (int index = myList.Count - 1; index >= 0; index--)
            {
                strB.Append(myList[index]);
                strB.AppendLine();
            }
            WriteToFile(writeToPath, strB.ToString());
            Console.WriteLine("Success");
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("The arument is out of range!");
        }
        catch(Exception)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }

    static void Main(string[] args)
    {
        string pathWithText = @"..\..\..\Files\test.txt";
        string pathWithWordList = @"..\..\..\Files\words.txt";
        string pathToResult = @"..\..\..\Files\result.txt";
        CountTheWords(pathWithText, pathWithWordList, pathToResult);
    }
}

