using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    /*
     7. Replace sub-string

    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).

    */
    static void Main()
    {
        StreamReader replace = new StreamReader(@"..\..\..\Files\07StartFinish.txt");
        StreamWriter replaceWrite = new StreamWriter(@"..\..\..\Files\07Write.txt");
        using (replace)
        {
            using (replaceWrite)
            {
                string text = String.Empty;
                text = (replace.ReadToEnd());
                string word = "finish";
                string wordInText = "start";

                text = text.Replace(wordInText, word);
                replaceWrite.Write(text);
            }
        }
    }
}

