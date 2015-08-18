using System;
using System.Globalization;
using System.Threading;
class AgeAfterTenYears
{
    /* Problem 15.* Age after 10 Years

        Write a program to read your birthday from the 
        console and print how old you are now and how old you will 
        be after 10 years. */

    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("bg-Bg");
        Console.Write("Enter birthdate: ");
        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;
        int day = DateTime.Now.Day;
        if (month - birthDate.Month < 0)
        {
            int yourAge = (year - birthDate.Year) - 1;
            Console.WriteLine("Your age is: " + yourAge);
            Console.WriteLine("Your age in 10 years will be " + (10 + yourAge));
        }
        else
        {
            if (month - birthDate.Month == 0)
            {
                if (day - birthDate.Day >= 0)
                {
                    int yourAge = (year - birthDate.Year);
                    Console.WriteLine("Your age is: " + yourAge);
                    Console.WriteLine("Your age in 10 years will be " + (10 + yourAge));
                }
                else
                {

                    int yourAge = (year - birthDate.Year);
                    Console.WriteLine("Your age is: " + yourAge);
                    Console.WriteLine("Your age in 10 years will be " + (10 + yourAge));
                }
            }
            else
            {
                int yourAge = (year - birthDate.Year);
                Console.WriteLine("Your age is: " + yourAge);
                Console.WriteLine("Your age in 10 years will be " + (10 + yourAge));
            }
        }
    }
}

