using System;

class NumberComparer
{
    /*
      4. Number Comparer

        Write a program that gets two numbers from the console and prints 
        the greater of them.
        Try to implement this without if statements.
    */

    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("The greater number is: ");
        double greater = a < b ? b : a;
        Console.WriteLine(greater);
    }
}

