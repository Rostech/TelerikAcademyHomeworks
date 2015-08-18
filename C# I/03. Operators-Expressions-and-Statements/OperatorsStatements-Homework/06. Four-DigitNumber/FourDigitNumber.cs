using System;

namespace _06.Four_DigitNumber
{
    class FourDigitNumber
    {
        /* Four-Digit Number

        Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).

    */
        static void Main()
        {
            Console.Write("Enter four-digit number: ");
            string number = Console.ReadLine();
            int sum = 0;
            for(int i = 0; i < number.Length; i++)
            {
                sum += (int)number[i] - '0';
            }
            Console.WriteLine("sum of digits: " + sum);
            string reversed = "";
            for(int i = number.Length-1; i >= 0; i--)
            {
                reversed += number[i];
            }
            Console.WriteLine("reversed: " + reversed);
            string lastDigitFirst = "";
            lastDigitFirst += number[number.Length - 1];
            for(int i=0; i < number.Length - 1; i++)
            {
                lastDigitFirst += number[i];
            }
            Console.WriteLine("last digit in front: " + lastDigitFirst);
            string secondAndThird = "";
            secondAndThird += number[0];
            secondAndThird += number[2];
            secondAndThird += number[1];
            secondAndThird += number[3];
            Console.WriteLine("second and third digits exchanged: " + secondAndThird);
            Console.WriteLine();
        }
    }
}
