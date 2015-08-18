using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class DeleteOddLines
{
    /*
         Problem 9. Delete odd lines

        Write a program that deletes from given text file all odd lines.
        The result should be in the same file.
         */
    static void Main()
    {
        var fs = File.Open(@"..\..\..\Files\09DeleteOddRows.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        StreamReader delete = new StreamReader(fs);
        StreamWriter write = new StreamWriter(fs);

        using (delete)
        {
            using (write)
            {
                int lineNumber = 0;
                string line = delete.ReadLine();
                string final = string.Empty;

                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 != 0)
                    {
                        final += line;
                        final += "\n";
                    }
                    line = delete.ReadLine();
                }
                write.WriteLine();
                write.WriteLine("----------------------------------------------------------");
                write.WriteLine("Results starts here: ");
                write.WriteLine("----------------------------------------------------------");
                write.Write(final);
            }
        }
    }
}

