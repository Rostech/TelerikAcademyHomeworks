using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    /*
     19. Dates from text in Canada

        Write a program that extracts from a given text all dates that 
        match the format DD.MM.YYYY.
        Display them in the standard date format for Canada.

    */
    static void Main()
    {
        string text = @"I was born at 14.06.1980. 
                       My sister was born at 3.7.1984. In 5/1999 I graduated my high school. 
                     The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

        string pattern = @"[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}";
        Match match = Regex.Match(text, pattern);
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Ca");
        while (match.Success)
        {
            Console.WriteLine(match);
            match = match.NextMatch();
        }
    }
}

