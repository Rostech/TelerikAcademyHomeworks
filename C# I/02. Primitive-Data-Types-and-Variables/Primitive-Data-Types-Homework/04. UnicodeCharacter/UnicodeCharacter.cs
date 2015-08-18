using System;

class UnicodeCharacter
{
    /* Unicode Character

        Declare a character variable and assign it with the symbol 
        that has Unicode code 42 (decimal) using the \u00XX syntax, 
        and then print it.
    */
        
    static void Main()
    {
        char unicodeVar = '\u002A';
        Console.WriteLine(unicodeVar);
    }
}

