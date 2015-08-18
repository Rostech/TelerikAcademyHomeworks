using System;

class CalculateNDivideKFactorials
{
    /*
      6. Calculate N! / K!

        Write a program that calculates n! / k! for given n and k 
        (1 < k < n < 100).
        Use only one loop.
    */
    static void Main()
    {
        Console.Title = "Calculate N!/K!";
        int n, k;
        string strN, strK;
        Console.Write("Enter N: ");
        strN = Console.ReadLine();
        Console.Write("Enter K: ");
        strK = Console.ReadLine();
        if(!int.TryParse(strN, out n) || !int.TryParse(strK, out k) 
            || (1 > n || 1 > k) || (100 < n || 100 < k) || n < k)
        {
            Console.WriteLine("Incorect input!");
        }
        else
        {
            int factorialN = 1;
            int factorialK = 1;
            do
            {
                factorialN *= n;
                n--;
                if(k >= 1)
                {
                    factorialK *= k;
                    k--;
                }
            } while (n >= 1);
            Console.WriteLine("Factorial K: " + factorialK);
            Console.WriteLine("Factorial N: " + factorialN);
            Console.WriteLine("N!/K! = " + factorialN / factorialK);
        }
    }
}

