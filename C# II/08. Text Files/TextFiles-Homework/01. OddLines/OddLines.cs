using System;
using System.IO;

class OddLines
{
    /*
     1. Odd lines

        Write a program that reads a text file and prints on the console 
        its odd lines.

    */
    static void Main()
    {
        string path = @"..\..\..\Files\file.txt";
        try
        {
            StreamReader text = new StreamReader(path);
            using (text)
            {
                int lineNum = 0;
                string line = text.ReadLine();
                while (line != null)
                {
                    lineNum++;
                    if(lineNum % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNum, line);
                    }
                    line = text.ReadLine();
                }
            }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file is not found!");
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Empty path!");
        }
        catch(IOException)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }
}

