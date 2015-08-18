using System;
using System.IO;

class CompareTextFiles
{
    /*
     4. Compare text files

        Write a program that compares two text files line by line and 
        prints the number of lines that are the same and the number of 
        lines that are different.
        Assume the files have equal number of lines.

    */
    static void Main()
    {
        string file1 = @"..\..\..\Files\file.txt";
        string file2 = @"..\..\..\Files\fileFor04Task.txt";
        int same = 0;
        int different = 0;
        try
        {
            StreamReader text1 = new StreamReader(file1);
            StreamReader text2 = new StreamReader(file2);
            using(text1)
            {
                using(text2)
                {
                    string line1 = text1.ReadLine();
                    string line2 = text2.ReadLine();
                    while(line1 != null)
                    {
                        if(line1.Equals(line2))
                        {
                            same++;
                        }
                        else
                        {
                            different++;
                        }
                        line1 = text1.ReadLine();
                        line2 = text2.ReadLine();
                    }
                }
            }
            Console.WriteLine("The same lines in the two files are: " + same);
            Console.WriteLine("The different line in the two files are: " + different);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path!");
        }
        catch (IOException)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }
}

