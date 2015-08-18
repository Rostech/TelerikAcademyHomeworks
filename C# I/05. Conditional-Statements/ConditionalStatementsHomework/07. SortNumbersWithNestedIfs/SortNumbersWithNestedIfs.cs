using System;

class SortNumbersWithNestedIfs
{
    /* 7. Sort 3 Numbers with Nested Ifs

        Write a program that enters 3 real numbers and prints 
        them sorted in descending order.
        Use nested if statements.

    */
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        string result = "";
        if(a>=b && a >= c)
        {
            result += a + " ";
            if(b >= c)
            {
                result += b + " ";
                result += c + " ";
            }
            else
            {
                result += c + " ";
                result += b + " ";
            }
        }
        else if (b >= a && b >= c)
        {
            result += b + " ";
            if (a >= c)
            {
                result += a + " ";
                result += c + " ";
            }
            else
            {
                result += c + " ";
                result += a + " ";
            }
        } 
        else if (c >= b && c >= a)
        {
            result += c + " ";
            if (a >= b)
            {
                result += a + " ";
                result += b + " ";
            }
            else
            {
                result += b + " ";
                result += a + " ";
            }
        }
        Console.WriteLine(result);
    }
}

