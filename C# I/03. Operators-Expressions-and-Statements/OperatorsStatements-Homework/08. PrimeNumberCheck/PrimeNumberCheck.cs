using System;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        /*
           Prime Number Check

            Write an expression that checks if given positive integer 
            number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
        */
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 9, 97, 51, -3, 0 };
            bool prime = true;
            for(int i = 0; i < numbers.Length; i++)
            {
                prime = false;
                for(int j = 2; j < numbers[i]; j++)
                {
                    if(numbers[i] % j == 0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                    }
                }
                if(prime || numbers[i] == 2 )
                {
                    Console.WriteLine("number: {0}  Prime? true",numbers[i]);
                }
                else
                {
                    Console.WriteLine("number: {0}  Prime? false", numbers[i]);
                }
            }
        }
    }
}
