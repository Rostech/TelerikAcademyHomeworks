using System;
using System.IO;

class ReadFileContent
{
    /*
     3. Read file contents

        Write a program that enters file name along with its full file 
        path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it 
        on the console.
        Find in MSDN how to use System.IO.File.ReadAllText(…).
        Be sure to catch all possible exceptions and print user-friendly
        error messages.

    */
    static void Main(string[] args)
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        Console.Write("Enter path: ");
        string path = Console.ReadLine();
        path += fileName;
        try
        {
            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();
            Console.WriteLine(text);
            sr.Close();
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file was not found at " + path);
        }
        catch(FileLoadException)
        {
            Console.WriteLine("The file could not be loaded!");
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("The path is too long!");
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Empty path name is not legal!");
        }
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the path {0} is denied!", path);
        }
        catch(Exception)
        {
            Console.WriteLine("Something went wrong :(");
        }
    }
}

