using System;

class ZeroSubset
{
    /*
         12.* Zero Subset

         We are given 5 integer numbers. Write a program that finds all 
         subsets of these numbers whose sum is 0.
         Assume that repeating the same subset several times is not a 
         problem.
    */

    static void Main()
    {
        Console.WriteLine("Enter five numbers ");
        int[] numbers = new int[5];
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        bool noZeroSubset = true;
        // combination without repetition 2 numbers 
        for(int i = 0; i <= numbers.Length -1; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine("{0} + {1}  = 0", numbers[i], numbers[j]);
                    noZeroSubset = false;
                }
            }
        }
        // combination without repetition 3 numbers 
        int number1 = numbers[0];
        for (int g = 0; g < numbers.Length - 1; g++)
        {
            number1 = numbers[g];
            for (int i = 1; i <= numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if ((number1 + numbers[i]) + numbers[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2}  = 0", number1, numbers[i], numbers[j]);
                        noZeroSubset = false;
                    }
                }
            }
        }
        // combination without repetition 4 numbers 
        number1 = numbers[0];
        int number2 = numbers[1];
        for (int g = 0; g < numbers.Length - 3; g++)
        {
            number1 = numbers[g];
            number2 = numbers[g + 1];
            for (int i = 2; i <= numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (((number1 + number2) + numbers[i]) + numbers[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} + {3} = 0", number1, number2, numbers[i], numbers[j]);
                        noZeroSubset = false;
                    }
                }
            }
        }
        // combination without repetition 5 numbers 
        if((numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            noZeroSubset = false;
        }
        if(noZeroSubset)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

