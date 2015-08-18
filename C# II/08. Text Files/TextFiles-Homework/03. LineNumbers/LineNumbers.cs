using System;
using System.IO;

class LineNumbers
{
    /*
        3. Line numbers

        Write a program that reads a text file and inserts line numbers
        in front of each of its lines.
        The result should be written to another text file.

    */
    
    static void Main(string[] args)
    {
        string file1 = @"..\..\..\Files\file.txt";
        string newFile = @"..\..\..\Files\fileLineNumbersTask03.txt";
        try
        {
            StreamReader text1 = new StreamReader(file1);
            StreamWriter writeTo = new StreamWriter(newFile);
            using (writeTo)
            {
                using (text1)
                {
                    string line = text1.ReadLine();
                    int lineNumber = 0;
                    while (line != null)
                    {
                        lineNumber++;
                        writeTo.WriteLine("{0:D2}. {1}",lineNumber,line);
                        line = text1.ReadLine();
                    }
                }
            }
            Console.WriteLine("Success. The file name is \"fileLineNumbersTask03.txt\"");
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

