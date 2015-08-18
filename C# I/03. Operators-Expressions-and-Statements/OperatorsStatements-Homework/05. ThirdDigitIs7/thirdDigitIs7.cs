using System;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        /* Third Digit is 7?

        Write an expression that checks for given integer if its third digit from right-to-left is 7.
        */
        static void Main()
        {
            int[] numbers = { 5, 701, 9703, 877, 777877, 9999799 };
            for(int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i].ToString();
                if(number.Length >= 3)
                {
                    if(number[number.Length - 3] == '7')
                    {
                        Console.WriteLine("number: {0}  Third digit 7? true",number);
                    }
                    else
                    {
                        Console.WriteLine("number: {0}  Third digit 7? false", number);
                    }
                }
                else
                {
                    Console.WriteLine("number: {0}  Third digit 7? false", number);
                }
            }
        }
    }
}
