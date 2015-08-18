using System;
using System.Globalization;

class DateDifference
{
    /*
        16. Date difference

    Write a program that reads two dates in the format: day.month.year 
    and calculates the number of days between them.

        Example:
            
        Enter the first date: 27.02.2006
        Enter the second date: 3.03.2006
        Distance: 4 days

    */
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            new CultureInfo("bg-Bg");

        Console.WriteLine("Enter first date: ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter second date: ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        TimeSpan span = DateTime.Compare(date2, date1) > 0 ? date2.Subtract(date1) : date1.Subtract(date2);
        Console.WriteLine("Distance " + span.TotalDays);
        
    }
}

