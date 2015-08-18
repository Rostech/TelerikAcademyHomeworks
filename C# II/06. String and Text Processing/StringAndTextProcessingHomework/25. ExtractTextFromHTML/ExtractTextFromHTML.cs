using System;
using System.Text;

class ExtractTextFromHTML
{
    /*
     25. Extract text from HTML

        Write a program that extracts from given HTML file its title 
        (if available), and its body text without the HTML tags.

            Example input:
            
            <html>
              <head><title>News</title></head>
              <body><p><a href="http://academy.telerik.com">Telerik
                Academy</a>aims to provide free real-world practical
                training for young people who want to turn into
                skilful .NET software engineers.</p></body>
            </html>
            
            Output:
            
            Title: News
            
            Text: Telerik Academy aims to provide free real-world practical 
            training for young people who want to turn into skilful .NET 
            software engineers.
    */
    static void Main(string[] args)
    {
        string htmlText = @" <html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">
Telerik Academy</a>aims to provide free real-world practical
training for young people who want to turn into
skilful .NET software engineers.</p></body>
</html>";
        int index = htmlText.IndexOf("<title>");
        string title = string.Empty;
        if(index != -1)
        {
            int indexLength = 0;
            index += "<title>".Length;
            while(htmlText[index + indexLength] != '<')
            {
                indexLength++;
            }
            title = htmlText.Substring(index, indexLength);
            Console.WriteLine("Title: " + title);
        }
        index = htmlText.IndexOf("<body>");
        string body = htmlText.Substring(index);
        StringBuilder strB = new StringBuilder();
        for (int i = index; i < htmlText.Length; i++)
        {
            if (htmlText[i] == '<')
            {
                while (htmlText[i] != '>')
                {
                    i++;
                }
            }
            else
            {
                strB.Append(htmlText[i]);
            }
        }
        Console.WriteLine(strB.ToString());
    }
}

