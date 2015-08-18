using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    /*
     6. Save sorted names

        Write a program that reads a text file containing a list of strings,
        sorts them and saves them to another text file.

        Example:
        input.txt 	output.txt
        Ivan        George
        Peter       Ivan
        Maria       Maria
        George 	    Peter
        
    */
    static void Main()
    {
        string file = @"..\..\..\Files\sortNames06Task.txt";
        string newFile = @"..\..\..\Files\sortNames06TaskResult.txt";
        try
        {
            StreamReader readFile = new StreamReader(file);
            StreamWriter writeFile = new StreamWriter(newFile);
            using (writeFile)
            {
                List<string> names = new List<string>();
                using (readFile)
                {
                    string line = readFile.ReadLine();
                    while(line != null)
                    {
                        names.Add(line);
                        line = readFile.ReadLine();
                    }
                    for(int i = 0; i < names.Count; i++)
                    {
                        for (int j = i; j < names.Count; j++)
                        {
                            if (String.Compare(names[i], names[j]) > 0)
                            {
                                string change = names[i];
                                names[i] = names[j];
                                names[j] = change;
                            }
                        }
                    }
                }
                foreach (string name in names)
                {
                    writeFile.WriteLine(name);
                }
            }
            Console.WriteLine("Success. The result is in \"sortNames06TaskResult.txt\"");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory is not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }
}

