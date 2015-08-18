using System;
using System.Net;

class DownloadFile
{
    /*
        4. Download file

        Write a program that downloads a file from Internet 
        (e.g. Ninja image) and stores it the current directory.
        Find in Google how to download files in C#.
        Be sure to catch all exceptions and to free any used resources 
        in the finally block.

    */
    static void Main(string[] args)
    {
        string remoteURL = "http://telerikacademy.com/Content/Images/news-img01.png";
        string toFile = @"..\..\ninja.png";
        Console.Write("Enter the adres of the file: ");
        remoteURL = Console.ReadLine();
        Console.Write("Enter where to save the file: ");
        string path = Console.ReadLine();
        Console.Write("Save as (name of the file + .(e.g. png)): ");
        toFile = path + Console.ReadLine();
        WebClient myWebClient = new WebClient();
        try
        {
            myWebClient.DownloadFile(remoteURL, toFile);
            Console.WriteLine("The file is saved at {0}", toFile);
        }
        catch(WebException)
        {
            Console.WriteLine("Could not find file at " + remoteURL);
        }
        catch(UriFormatException)
        {
            Console.WriteLine("Invalid path to file");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path name is not legal!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the path {0} is denied!", path);
        }
        catch (Exception)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
        finally
        {
            myWebClient.Dispose();
        }
    }
}

