using System;
using System.IO;

class ConcatenateTextFiles
{
    /*
      2. Concatenate text files

        Write a program that concatenates two text files into another 
        text file.

    */
    static void Main()
    {
        string file1 = @"..\..\..\Files\file.txt";
        string file2 = @"..\..\..\Files\file.txt";
        string newFile = @"..\..\..\Files\fileConcatTask02.txt";
        try
        {
            StreamReader text1 = new StreamReader(file1);
            StreamReader text2 = new StreamReader(file2);
            StreamWriter writeTo = new StreamWriter(newFile);
            using(writeTo)
            {
                writeTo.WriteLine("-----------first file---------");
                using(text1)
                {
                    string line = text1.ReadLine();
                    while(line != null)
                    {
                        writeTo.WriteLine(line);
                        line = text1.ReadLine();
                    }
                }
                writeTo.WriteLine("-----------second file---------");
                using (text2)
                {
                    string line = text2.ReadLine();
                    while (line != null)
                    {
                        writeTo.WriteLine(line);
                        line = text2.ReadLine();
                    }
                }
            }
            Console.WriteLine("Success. The file name is \"fileConcatTask02.txt\"");
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

