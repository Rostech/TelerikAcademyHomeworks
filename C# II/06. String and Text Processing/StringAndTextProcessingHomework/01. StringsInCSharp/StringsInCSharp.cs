using System;

class StringsInCSharp
{
    /*
      1. Strings in C#.

        Describe the strings in C#.
        What is typical for the string data type?
        Describe the most important methods of the String class.

    */
    static void Main()
    {
        string IamString = @"Hello, I am a string and I will tell you about srings.
- Strings are sequence of characters
- Each character is Unicode symbol 
- String are represented by System.String objects in .NET Framework 
- Strings are immutable (read-only) sequence of characters 
- Strings are stored in the dynamic memory (menaged heap) 
- System.String is reference type 
- String objects are like arrays of characters
Important methods are: 
String1.Equals(String1) - checks if two strings are equal 
String.Concat(str1, str2) - Concatenates strings
IndexOf(string str) - returns the first found index of the string found in other string or -1 
INdexOf(string str, int startIndex)- returns the index of the string found in other string or -1 but starts from position
LastIndexOf(string) - returns the last found index of the string ";
        Console.WriteLine(IamString);
    }
}

