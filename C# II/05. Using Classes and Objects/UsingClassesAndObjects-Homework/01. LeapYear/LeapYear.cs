using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class LeapYear
    {
        /*
          1. Leap year

            Write a program that reads a year from the console and checks 
            whether it is a leap one.
            Use System.DateTime.

        */
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year is leap!");
            }
            else
            {
                Console.WriteLine("The year is NOT leap!");
            }
        }
    }
}
