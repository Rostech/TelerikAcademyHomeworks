using System;

class BeerTime
{
    /*
     10.* Beer Time

        A beer time is after 1:00 PM and before 3:00 AM.
        Write a program that enters a time in format “hh:mm tt” 
        (an hour in range [01...12], a minute in range [00…59] and 
        AM / PM designator) and prints beer time or non-beer time 
        according to the definition above or invalid time if the time 
        cannot be parsed. Note: You may need to learn how to parse dates 
        and times
     */

    static void Main()
    {
        Console.Write("Enter time in the format \n'hh:mm tt' (example 1:00 PM): ");
        DateTime time = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
        byte startTime = 13, beforeMidnight = 24, afterMidnight = 0, finishTime = 3;
        if(time.Hour >= startTime && time.Hour <= beforeMidnight || time.Hour >= afterMidnight && time.Hour < finishTime)
        {
            Console.WriteLine("Result: beer time");
        }
        else
        {
            Console.WriteLine("Result: non-beer time");
        }
    }
}

