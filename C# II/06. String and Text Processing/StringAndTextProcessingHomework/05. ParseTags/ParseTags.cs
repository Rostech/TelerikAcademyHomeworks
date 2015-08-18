using System;

    class ParseTags
    {
        /*
         5. Parse tags

            You are given a text. Write a program that changes the text in 
            all regions surrounded by the tags <upcase> and </upcase> to 
            upper-case.
            The tags cannot be nested.

            Example: We are living in a <upcase>yellow submarine</upcase>. 
            We don't have <upcase>anything</upcase> else.
            
            The expected result: We are living in a YELLOW SUBMARINE. We 
            don't have ANYTHING else.
        
        */
        static void Main(string[] args)
        {
            string text = @"We are living in a <upcase>yellow submarine</upcase>. 
We don't have <upcase>anything</upcase> else.";
            string textBefore = text;
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            int openTagIndex = text.IndexOf(openTag);
            openTagIndex += openTag.Length;
            int closeTagIndex = text.IndexOf(closeTag);
            int substringLength = closeTagIndex - openTagIndex;
            text = text.Replace(text.Substring(openTagIndex, substringLength), 
                text.Substring(openTagIndex, substringLength).ToUpper());
            while(closeTagIndex >= 0)
            {
                openTagIndex = text.IndexOf(openTag, openTagIndex);
                openTagIndex += openTag.Length;
                closeTagIndex = text.IndexOf(closeTag, closeTagIndex +1);
                substringLength = closeTagIndex - openTagIndex;
                closeTagIndex++;
                if(substringLength < 0)
                {
                    break;
                }
                text = text.Replace(text.Substring(openTagIndex, substringLength),
                    text.Substring(openTagIndex, substringLength).ToUpper());
            }
            text = text.Replace("<upcase>", "");
            text = text.Replace("</upcase>", "");
            Console.WriteLine("Text is: ");
            Console.WriteLine(textBefore);
            Console.WriteLine("\nResult:");
            Console.WriteLine(text);
        }
    }

