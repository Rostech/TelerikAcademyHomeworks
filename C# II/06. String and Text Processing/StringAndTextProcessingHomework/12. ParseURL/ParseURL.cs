using System;

class ParseURL
{
    /*
     12. Parse URL

        Write a program that parses an URL address given in the format: 
        [protocol]://[server]/[resource] and extracts from it the 
        [protocol], [server] and [resource] elements.
      
                                             Example:
                URL 	                                    Information
                http://telerikacademy.com/Courses
                /Courses/Details/212 	                    [protocol] = http
                                                            [server] = telerikacademy.com
                                                            [resource] = /Courses/Courses/Details/212
 
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter website: ");
        string website = Console.ReadLine();
        string[] arrWithElements = website.Split(new string[] {"://"}, StringSplitOptions.RemoveEmptyEntries);
        string protocol = arrWithElements[0];
        arrWithElements = arrWithElements[1].Split(new char[] {'/'},2);
        string server = arrWithElements[0];
        string resource = arrWithElements[1];
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);

    }
}

