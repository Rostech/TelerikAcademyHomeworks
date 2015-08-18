using System;

class SquareRoot
{
    /*
     1. Square root

        Write a program that reads an integer number and calculates and 
        prints its square root.
            - If the number is invalid or negative, print Invalid number.
            - In all cases finally print Good bye.
        Use try-catch-finally block.

    */
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
            if(number < 0)
            {
                Exception ex = new Exception();
                throw ex;
            }
            Console.WriteLine("The square root is: " + Math.Sqrt(number));
        }
        catch
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

