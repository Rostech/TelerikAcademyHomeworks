using System;

    class EnglishDigit
    {
        /*
          3. English digit

         Write a method that returns the last digit of given integer 
         as an English word.

        */

        static string EnglishDigitMethod(int number)
        {
            Console.Write("\nLast digit as word: ");
            string[] numbers = {
              "zero", "one", "two", "three", "four", "five",
              "six", "seven", "eight", "nine"
            };
            return numbers[number % 10];
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            Console.WriteLine(EnglishDigitMethod(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine();
        }
    }

