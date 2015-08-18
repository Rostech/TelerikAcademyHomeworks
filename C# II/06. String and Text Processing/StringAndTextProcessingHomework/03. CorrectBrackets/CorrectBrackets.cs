using System;

class CorrectBrackets
{
    /*
     3. Correct brackets

        Write a program to check if in a given expression the brackets are 
       put correctly.

       Example of correct expression: ((a+b)/5-d). Example of incorrect 
       expression: )(a+b)).
    
    */
    static void Main(string[] args)
    {
        Console.Write("Enter mathematical expression with brackets: ");
        string input = Console.ReadLine();
        int counBrackets = 0;
        bool incorect = false;
        for(int i = 0; i < input.Length; i++)
        {
            if(input[i] == '(')
            {
                counBrackets++;
            }
            if(input[i] == ')')
            {
                counBrackets--;
            }
            if(counBrackets < 0)
            {
                incorect = true;
                break;
            }
        }
        if(counBrackets != 0 || incorect)
        {
            Console.WriteLine("The expression is incorrect!");
        }
        else
        {
            Console.WriteLine("Correct expression!");
        }
    }
}

