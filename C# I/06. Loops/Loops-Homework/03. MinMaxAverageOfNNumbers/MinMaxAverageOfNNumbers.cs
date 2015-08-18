using System;

class MinMaxAverageOfNNumbers
{
    /*
     3. Min, Max, Sum and Average of N Numbers

        Write a program that reads from the console a sequence of n integer 
        numbers and returns the minimal, the maximal number, the sum and the 
        average of all numbers (displayed with 2 digits after the decimal 
        point).
        The input starts by the number n (alone in a line) followed by n 
        lines, each holding an integer number.
        The output is like in the examples below.
    */

    static void Main()
    {
        Console.Write("Enter number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrWithNumbers = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ",i+1);
            arrWithNumbers[i] = int.Parse(Console.ReadLine());
        }
        int max = arrWithNumbers[0];
        int min = arrWithNumbers[0];
        int sum = 0;
        double avg = 0;
        for(int i = 0; i < n; i++)
        {
            if(max < arrWithNumbers[i])
            {
                max = arrWithNumbers[i];
            }
            if(min > arrWithNumbers[i])
            {
                min = arrWithNumbers[i];
            }
            sum += arrWithNumbers[i];
        }
        avg = (double)sum / n;
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:0.00}", avg);
    }
}

