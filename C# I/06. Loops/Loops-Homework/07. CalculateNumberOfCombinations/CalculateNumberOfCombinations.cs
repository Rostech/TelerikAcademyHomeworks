using System;
using System.Numerics;

class CalculateNumberOfCombinations
{
    /*
      7. Calculate N! / (K! * (N-K)!)

        In combinatorics, the number of ways to choose k different members 
        out of a group of n different elements (also known as the number 
        of combinations) is calculated by the following formula: formula 
        For example, there are 2598960 ways to withdraw 5 cards out of a 
        standard deck of 52 cards.
        Your task is to write a program that calculates n! / (k! * (n-k)!) 
        for given n and k (1 < k < n < 100). Try to use only two loops.

    */
    static void Main()
    {
        Console.Title = "Calculate N!/(K! * (N-K)!)";
        int n, k;
        string strN, strK;
        Console.Write("Enter N: ");
        strN = Console.ReadLine();
        Console.Write("Enter K: ");
        strK = Console.ReadLine();
        if (!int.TryParse(strN, out n) || !int.TryParse(strK, out k)
            || (1 > n || 1 > k) || (100 < n || 100 < k) || n < k)
        {
            Console.WriteLine("Incorect input!");
        }
        else
        {
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            int nMinusK = n - k;
            if (nMinusK == 0)
                nMinusK = 1;
            BigInteger factorialNMinusK = 1;
            do
            {
                factorialN *= n;
                n--;
                if (k >= 1)
                {
                    factorialK *= k;
                    k--;
                }
            } while (n >= 1);
            do
            {
                factorialNMinusK *= nMinusK;
                nMinusK--;
            } while (nMinusK >= 1);
            BigInteger result = factorialN / (factorialK * factorialNMinusK);
            Console.WriteLine("n!/(k! * (n-k)!) = " + result);
        }
    }
}

