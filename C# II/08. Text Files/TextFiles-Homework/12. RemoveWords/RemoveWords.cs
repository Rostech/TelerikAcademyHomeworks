using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program
{
    /*
        12. Remove words

        Write a program that removes from a text file all words listed 
        in given another text file.
        Handle all possible exceptions in your methods.
    
    */
    static void Main()
    {
        string path1 = @"..\..\..\Files\RemoveWords12Task.txt";
        string path2 = @"..\..\..\Files\RemoveWords12TaskListWithWords.txt";
        try
        {
            StreamReader file1 = new StreamReader(path1);
            StreamReader file2 = new StreamReader(path2);
            StringBuilder strB = new StringBuilder();
            using (file1)
            {
                string file1Str = file1.ReadToEnd();
                string[] arr1 = file1Str.Trim().Split(' ', '\n', '\t', '\r');
                using (file2)
                {
                    string file2Str = file2.ReadToEnd();
                    string[] arr2 = file2Str.Trim().Split(' ', '\n', '\t', '\r');
                    bool add = false;
                    for (int i = 0; i < arr1.Length; i += 2)
                    {
                        add = true;
                        for (int j = 0; j < arr2.Length; j += 2)
                        {
                            if (String.Compare(arr1[i], arr2[j]) == 0)
                            {
                                add = false;
                                break;
                            }
                        }
                        if (add)
                        {
                            strB.AppendLine(arr1[i]);
                        }
                    }
                }
            }
            File.WriteAllText(path1, strB.ToString());
            Console.WriteLine("Success");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("An argument exception accured!");
        }
        catch (Exception)
        {
            Console.WriteLine("Oops something went wrong!");
        }
    }
}

