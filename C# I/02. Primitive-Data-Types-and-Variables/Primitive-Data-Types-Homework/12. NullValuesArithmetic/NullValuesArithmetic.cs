using System;

class NullValuesArithmetic
{
    /* Null Values Arithmetic

         Create a program that assigns null values to an integer and 
         to a double variable.
         Try to print these variables at the console.
         Try to add some number or the null literal to these variables 
         and print the result.
    */

    static void Main()
    {
        int? varInt = null;
        double? varDouble = null;
        Console.WriteLine("int?: " + varInt);
        Console.WriteLine("double?: " + varDouble);
        varInt = 5;
        varDouble = 5.5;
        Console.WriteLine("int?: " + varInt);
        Console.WriteLine("double?: " + varDouble);
    }
}

