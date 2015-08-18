using System;

class IntegerCalculations
{
    /*
     14. Integer calculations

            Write methods to calculate minimum, maximum, average, sum 
            and product of given set of integer numbers.
            Use variable number of arguments.

    */

    static void CalculateStuff(params int[] theParams)
    {
        int minimum = theParams[0];
        int maximum = theParams[0];
        float average = 0f;
        int sum = 0;
        int product = 1;
        foreach(int param in theParams)
        {
            if(param < minimum)
            {
                minimum = param;
            }
            if(param > maximum)
            {
                maximum = param;
            }
            sum += param;
            product *= param;
        }
        average = sum / theParams.Length;
        Console.WriteLine("Minimum: " + minimum);
        Console.WriteLine("Maximum: " + maximum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
    }

    static void Main()
    {
        Console.WriteLine("Enter a variable number of parameters separated by space: ");
        CalculateStuff(Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse));
    }
}

