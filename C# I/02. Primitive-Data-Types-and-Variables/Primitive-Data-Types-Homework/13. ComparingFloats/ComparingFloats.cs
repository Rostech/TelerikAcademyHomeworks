using System;

class ComparingFloats
{
    /* Comparing Floats

        Write a program that safely compares floating-point 
        numbers (double) with precision eps = 0.000001.

        Note: Two floating-point numbers a and b cannot be compared 
        directly by a == b because of the nature of the floating-point 
        arithmetic. Therefore, we assume two numbers are equal if they 
        are more closely to each other than a fixed constant eps.
    */
    static void Main()
    {
        float eps = 0.000001f;
        double a = 5.00000005;
        double b = 5.00000001;
        if (a > b)
        {
            if(a - b <= eps)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
        else
        {
            Console.WriteLine(b - a);
            if (b - a <= eps)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }


    }
}

