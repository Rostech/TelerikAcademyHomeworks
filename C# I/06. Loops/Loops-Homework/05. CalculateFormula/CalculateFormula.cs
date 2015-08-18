using System;

class CalculateFormula
{
    /*
     5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

        Write a program that, for a given two integer numbers n and x, 
        calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        Use only one loop. Print the result with 5 digits after the 
        decimal point.
    */
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter numbre x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Calculate 1 + 1!/X + 2!/x^2 + ... + N!/X^N");

        double sum = 1;
        int iteration = 1;
        int factoral = 1;
        double power = 1;
        for(int i = 1; i <= n;)
        {
            if(i >= 1)
            {
                factoral *= i;
                i--;
                continue;
            }
            sum += factoral / Math.Pow(x, power++);
            factoral = 1;
            i = ++iteration;
            power = i;
        }
        Console.WriteLine("Result = {0:0.00000}",sum);
    }
}

