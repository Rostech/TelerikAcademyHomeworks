using System;

class SeriesOfLetters
{
    /*
      23. Series of letters

        Write a program that reads a string from the console and 
        replaces all series of consecutive identical letters with a 
        single one.
      
        Example:
        input 	                    output
        aaaaabbbbbcdddeeeedssaa 	abcdedsa

    */
    static void Main()
    {
        Console.WriteLine("enter series of letter: ");
        string seriesOfLetters = Console.ReadLine();
        int index = 0;
        int count = 0;
        while (index < seriesOfLetters.Length)
        {
            char letter = seriesOfLetters[index];
            for (int i = index; i < seriesOfLetters.Length; i++)
            {
                if (seriesOfLetters[i] == letter)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            string oldString = String.Empty;
            oldString = String.Concat(oldString, letter);
            oldString = oldString.PadLeft((count), letter);
            seriesOfLetters = seriesOfLetters.Replace(oldString, letter.ToString());
            index++;
            count = 0;
        }
        Console.WriteLine("result: ");
        Console.WriteLine(seriesOfLetters);
    }
}

