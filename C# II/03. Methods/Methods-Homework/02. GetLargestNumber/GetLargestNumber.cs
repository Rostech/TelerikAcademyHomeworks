using System;

class GetLargestNumber
{
    /*
         2. Get largest number

         Write a method GetMax() with two parameters that returns the 
        larger of two integers.
         Write a program that reads 3 integers from the console and 
        prints the largest of them using the method GetMax().

    */

    static int GetMax(int a, int b)
    {
        if (a >= b)
            return a;
        return b;
    }

    static void Main()
    {
        Console.Write("Enter 3 integers separated by space: ");
        int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if(GetMax(inputArr[0],inputArr[1]) >= inputArr[2])
        {
            Console.WriteLine("The largest number is: " + GetMax(inputArr[0], inputArr[1]));
        }
        else
        {
            Console.WriteLine("The largest number is: " + inputArr[2]);
        }
    }
}

