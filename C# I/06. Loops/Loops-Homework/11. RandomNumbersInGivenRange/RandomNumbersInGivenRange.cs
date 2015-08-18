using System;

class RandomNumbersInGivenRange
{
    /*
     11. Random Numbers in Given Range

        Write a program that enters 3 integers n, min and max (min != max)
        and prints n random numbers in the range [min...max].
     
    */
    static void Main()
    {
        Console.Write("Enter number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min range: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max range: ");
        int max = int.Parse(Console.ReadLine());
        while(min == max)
        {
            Console.WriteLine("min = max. It has to be min != max");
            Console.Write("Enter min range: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Enter max range: ");
            max = int.Parse(Console.ReadLine());
        }
        if(min > max)
        {
            int change = min;
            min = max;
            max = change;
        }
        Random randomGenerator = new Random();
        Console.Write("Random numbers: ");
        for(int i = 1; i <= n; i++)
        {
            Console.Write(randomGenerator.Next(min, max+1) + " ");
        }
        Console.WriteLine();
    }
}

