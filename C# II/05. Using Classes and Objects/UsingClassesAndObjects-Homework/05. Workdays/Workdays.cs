using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Workdays
{
    class Workdays
    {
        /*
           5. Workdays

             Write a method that calculates the number of workdays 
             between today and given date, passed as parameter.
             Consider that workdays are all days from Monday to Friday 
             except a fixed list of public holidays specified preliminary 
             as array.

        */

        static void CalculateWorkdays(DateTime date)
        {
            int[][] holidays = new int[13][];
            holidays[1] = new int[] { 1 };
            holidays[2] = new int[0];
            holidays[3] = new int[] { 3 };
            holidays[4] = new int[] { 18, 19, 20 };
            holidays[5] = new int[] { 1, 6, 24 };
            holidays[6] = new int[0];
            holidays[7] = new int[0];
            holidays[8] = new int[0];
            holidays[9] = new int[] { 6, 22 };
            holidays[10] = new int[0];
            holidays[11] = new int[] { 1 };
            holidays[12] = new int[] { 24, 25, 26, 31 };
            int countDays = 0;
            DateTime today = DateTime.Now;
            DateTime todayOutput = DateTime.Now;
            if(!(DateTime.Compare(date, DateTime.Now) > 0)) // date is after today
            {
                DateTime change = new DateTime();
                change = today;
                today = date;
                date = change;
                todayOutput = today;
            }
            int month = today.Month;
            bool passedAllHolidaisInMonth = false;
            bool todayIsHoliday = false;
            while(!DateTime.Equals(today.Date, date.Date))
            {
                if(!(today.DayOfWeek == DayOfWeek.Sunday || today.DayOfWeek == DayOfWeek.Saturday))
                {
                    if (!passedAllHolidaisInMonth)
                    {
                        for (int day = 0; day < holidays[month].Length; day++)
                        {
                            if (today.Day == holidays[today.Month][day])
                            {
                                todayIsHoliday = true;
                                if(today.Day == holidays[today.Month][holidays[today.Month].Length-1])
                                {
                                    passedAllHolidaisInMonth = true;
                                    Console.WriteLine("Last holiday in this moth: "+ today.Day);
                                }
                                break;
                            }
                        }
                    }
                    if (!todayIsHoliday)
                    {
                        countDays++;
                    }
                }
                today = today.AddDays(1);
                todayIsHoliday = false;
                if(month != today.Month)
                {
                    passedAllHolidaisInMonth = false;
                }
                month = today.Month;
            }
            Console.WriteLine("From {0} to {1} we have to work {2} {3}.", todayOutput.Date.ToShortDateString(),
                date.Date.ToShortDateString(), countDays, countDays != 1 ? "days":"day");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a date (month.day.year) : ");
            DateTime date = new DateTime();
            date= DateTime.Parse(Console.ReadLine());
            CalculateWorkdays(date);
        }
    }
}
