using System;

namespace _01.OddOrEaven
{
    class OddOrEaven
    {
        /*
          1. Odd or Even Integers

           Write an expression that checks if given integer is odd or even.

        */
        static void Main()
        {
            int[] numbers = { 3, 2, -2, -1, 0 };
            bool odd = false;
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("number {0} is Odd: ", numbers[i]);
                if(numbers[i] % 2 == 0)
                {
                    odd = false;
                    Console.WriteLine(odd);
                }
                else
                {
                    odd = true;
                    Console.WriteLine(odd);
                }
            }
        }
    }
}
