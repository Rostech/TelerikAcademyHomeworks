using System;

class FloatOrDouble
{
    /*  2. Float or Double?

        Which of the following values can be assigned to a variable of type float and which to a 
        variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        Write a program to assign the numbers in variables and print them to ensure no precision is lost. */

    static void Main()
    {
        double doubleValue0 = 34.567839023; //35.657439023
        Console.WriteLine("double: " + doubleValue0);
        float floatValue0 = 12.345f;
        Console.WriteLine("float: " + floatValue0);
        double doubleValue1 = 8923.1234857;
        Console.WriteLine("double: " + doubleValue1);
        float floatValue2 = 3456.091f;
        Console.WriteLine("float: " + floatValue2);
    }
}

