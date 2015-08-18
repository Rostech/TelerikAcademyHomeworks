using System;

class SumOfNNumbers
{
    /* 9. Sum of n Numbers

        Write a program that enters a number n and after that enters 
        more n numbers and calculates and prints their sum.
    */
    
    static void Main()
    {
        Console.Write("Enter number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        double number = 0;
        double sum = 0;
        for(int i = 1; i <= n; i ++)
        {
            Console.Write("enter number {0}: ", i);
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: " + sum);
    }
}

