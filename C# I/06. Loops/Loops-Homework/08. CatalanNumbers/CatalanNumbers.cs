using System;

class CatalanNumbers
{
    /*
      8. Catalan Numbers

         In combinatorics, the Catalan numbers are calculated by the 
         following formula: catalan-formula
         Write a program to calculate the nth Catalan number by given 
         n (1 <= n <= 100).

    */
    static void Main()
    {
        Console.Write("Enter nth Catalan number: ");
        double n = double.Parse(Console.ReadLine());
        double result = 1;
        for(int k = 2; k <= n; k++)
        {
            result *= (n + k) / k;
        }
        Console.WriteLine("Catalan(n) = " + result);
    }
}

