using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfIntegers
{
    class SumOfIntegers
    {
        /*
           6. Sum integers

            You are given a sequence of positive integer values written 
            into a string, separated by spaces.
            Write a function that reads these values from given string 
            and calculates their sum.

                Example:
                input 	output
                "43 68 9 23 318" 	461
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter e sequence of positive integers separated by space");
            string input = Console.ReadLine();
            int[] arr = Array.ConvertAll(input.Trim().Split(), int.Parse);
            int sum = 0;
            foreach (int number in arr)
            {
                sum += number;
            }
            Console.WriteLine(input.Length);
            Console.WriteLine("{0,-" + input.Length +"} {1,5}", "input", "output");
            Console.WriteLine("{0} {1,5}", input, sum);
        }
    }
}
