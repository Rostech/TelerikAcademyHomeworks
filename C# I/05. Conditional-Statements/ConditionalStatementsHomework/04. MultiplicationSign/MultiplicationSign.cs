using System;

class MultiplicationSign
{
    /*4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product
    of three real numbers, without calculating it.
    Use a sequence of if operators.
    */
    
    static void Main()
    {
        Console.Write("Enter (signed) numbre a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter (signed) number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter (signed) number c: ");
        double c = double.Parse(Console.ReadLine());
        bool foundZero = false;
        int minusSymbols = 0;
        if(a <= 0)
        {
            if(a == 0)
                foundZero = true;
            else
                minusSymbols++;
        }
        if(b <= 0)
        {
            if (b == 0)
                foundZero = true;
            else
                minusSymbols++;
        }
        if (c <= 0)
        {
            if (c == 0)
                foundZero = true;
            else
                minusSymbols++;
        }
        if(foundZero)
        {
            Console.WriteLine("Result: 0");
        }
        else
        {
            if(minusSymbols % 2 == 0)
            {
                Console.WriteLine("Result: +");
            }
            else
            {
                Console.WriteLine("Result: -");
            }
        }
    }
}

