using System;
using System.Text;
using System.IO;

class ExtractTextFromXML
{
    /*
     10. Extract text from XML

         Write a program that extracts from given XML file all the text 
         without the tags.

            Example:

        <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
    */
    static void Main(string[] args)
    {
        string filePath = @"..\..\..\Files\extractXML10Task.txt";
        string resultPath = @"..\..\..\Files\extractXML10TaskResult.txt";
        try
        {
            StreamWriter writeTo = new StreamWriter(resultPath);
            StreamReader readFrom = new StreamReader(filePath);
            StringBuilder strB = new StringBuilder();
            strB.Append("The text from the xml file is:");
            using(writeTo)
            {
                using(readFrom)
                {
                    string text = readFrom.ReadToEnd();
                    for(int i = 0; i < text.Length-1; i++)
                    {
                        if(text[i] == '>')
                        {
                            i++;
                            while(text[i] != '<')
                            {
                                strB.Append(text[i].ToString());
                                i++;
                            }
                            strB.Append(' ');
                        }
                    }
                }
                writeTo.WriteLine(strB.ToString());
            }
            Console.WriteLine("Success. The result is in \"extractXML10TaskResult.txt\"");
        }
        catch(FileLoadException)
        {
            Console.WriteLine("File could not end!");
        }
        catch(IOException)
        {
            Console.WriteLine("Input output exception!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path!");
        }
        catch (Exception)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }
}

