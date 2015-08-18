using System;

class SolveTasks
{
    /*
      13. Solve tasks

    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0

    */

    static int Menu()
    {
        Console.WriteLine("Choose from the folowing: ");
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation");
        Console.Write("Enter the number of your choice: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static decimal ReverseDigits(decimal number)
    {
        string num = number.ToString();
        string reverse = string.Empty;
        for(int i = num.Length-1; i >= 0; i--)
        {
            reverse += num[i];
        }
        decimal numReversed = Convert.ToDecimal(reverse);
        return numReversed;
    }

    static decimal Avarage(decimal[] e)
    {
        decimal avarage = 1;
        decimal sum = 0;
        for(int i = 0; i< e.Length; i++)
        {
            sum += e[i];
        }
        avarage = sum / e.Length;
        return avarage;
    }

    static decimal LinearEquation(decimal a, decimal b)
    {
        return (b * -1) / a;
    }

    static void Main()
    {
        int task = Menu();
        switch(task)
        {
            case 1:
                Console.Write("Enter a positive number: ");
                decimal number = decimal.Parse(Console.ReadLine());
                while(number < 0)
                {
                    Console.Write("Enter a positive number: ");
                    number = decimal.Parse(Console.ReadLine());
                }
                Console.WriteLine("Result is: " + ReverseDigits(number));
                break;
            case 2:
                Console.Write("Enter a sequence: ");
                decimal[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), decimal.Parse);
                while(arr.Length < 1)
                {
                    Console.WriteLine("Enter at least one element!");
                    Console.Write("Enter e sequence: ");
                    arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), decimal.Parse);
                }
                Console.WriteLine("Result is: " + Avarage(arr));
                break;
            case 3:
                Console.WriteLine("Solving linear equation ax + b = 0");
                Console.Write("Enter a: ");
                decimal a = decimal.Parse(Console.ReadLine());
                while(a == 0)
                {
                    Console.WriteLine("a should not be equal to zero!");
                    Console.Write("Enter a: ");
                    a = decimal.Parse(Console.ReadLine());
                }
                Console.Write("Enter b: ");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Result is: " + LinearEquation(a, b));
                break;
            default:
                Console.WriteLine("There is no task with number " + task);
                break;
        }
    }
}

