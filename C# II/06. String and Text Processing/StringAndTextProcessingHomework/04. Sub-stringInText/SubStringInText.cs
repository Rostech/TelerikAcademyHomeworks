using System;

class SubStringInText
{
    /*
       4. Sub-string in text

        Write a program that finds how many times a sub-string is 
        contained in a given text (perform case insensitive search).

        Example:
        
        The target sub-string is: in
        
        The text is as follows: We are living in an yellow submarine. 
        We don't have anything else. inside the submarine is very tight. 
        So we are drinking all the day. We will move out of it in 5 days.
        
        The result is: 9
     
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();
        Console.Write("Enter a string to search for: ");
        string searchFor = Console.ReadLine();
        int found = 0;
        int index = text.IndexOf(searchFor);
        while(index >= 0)
        {
            index++;
            found++;
            index = text.IndexOf(searchFor, index);
        }
        Console.WriteLine("\"{0}\" is found {1} {2}.", searchFor, found, found > 1 ? "times" : "time");
    }
}

