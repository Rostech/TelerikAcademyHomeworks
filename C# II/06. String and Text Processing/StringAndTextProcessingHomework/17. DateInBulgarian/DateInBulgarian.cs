using System;
using System.Globalization;
using System.Text;
class DateInBulgarian
{
    /*
        17. Date in Bulgarian

        Write a program that reads a date and time given in the format: 
        day.month.year hour:minute:second and prints the date and time 
        after 6 hours and 30 minutes (in the same format) along with 
        the day of week in Bulgarian.

    */
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            new CultureInfo("bg-Bg");
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Enter date (day.month.year hour:minute:second): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        date.AddHours(6.0);
        date.AddMinutes(30.0);
        switch(date.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Понеделник");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Вторник");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Сряда");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Четвъртък");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Петък");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Събота");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Неделя");
                break;
        }
    }
}

