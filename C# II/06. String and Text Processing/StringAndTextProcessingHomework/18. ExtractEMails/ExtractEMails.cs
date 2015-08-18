using System;

class ExtractEMails
{
    /*
        18. Extract e-mails

        Write a program for extracting all email addresses from given
        text.
        All sub-strings that match the format <identifier>@<host>…<domain> 
        should be recognized as emails
    */

    static void Main(string[] args)
    {
        Console.Write("Enter email adres: ");
        string email = Console.ReadLine();
        string[] split = email.Split('@');
        string identifier = split[0];
        int index = split[1].LastIndexOf('.');
        string host = split[1].Substring(0, index);
        string domain = split[1].Substring(index);
        domain = domain.TrimStart('.');
        Console.WriteLine("Identifier: " + identifier);
        Console.WriteLine("Host: " + host);
        Console.WriteLine("Domain: " + domain);

    }
}

