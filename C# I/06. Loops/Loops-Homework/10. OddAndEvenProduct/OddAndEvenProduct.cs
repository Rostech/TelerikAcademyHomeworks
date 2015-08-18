using System;

class OddAndEvenProduct
{
    /*
      10. Odd and Even Product

        You are given n integers (given in a single line, separated by a 
        space).
        Write a program that checks whether the product of the odd 
        elements is equal to the product of the even elements.
        Elements are counted from 1 to n, so the first element is odd, 
        the second is even, etc.

    */
    static void Main()
    {
        Console.WriteLine("Enter several numbers separated by space: ");
        string numbers = Console.ReadLine();
        string[] numbersArr = numbers.Split(' ');
        int odd = 1, even = 1;
        int check = 0;
        int oddOrEven = 1;
        string productOdd = "";
        string productEven = "";
        bool notOnlyOneNumber = false;
        for(int i = 1; i <= numbersArr.Length; i++)
        {
            if(!int.TryParse(numbersArr[i-1], out check))
            {
                oddOrEven--;
            }
            else if(oddOrEven % 2 != 0 )
            {
                odd *= int.Parse(numbersArr[i - 1]);
                productOdd += numbersArr[i - 1];
                if (i < numbersArr.Length - 1)
                {
                    productOdd += " * ";
                }
            }
            else if (oddOrEven % 2 == 0)
            {
                if(!notOnlyOneNumber)
                {
                    even = 1;
                }
                notOnlyOneNumber = true;
                even *= int.Parse(numbersArr[i - 1]);
                productEven += numbersArr[i - 1];
                if (i < numbersArr.Length - 1)
                {
                    productEven += " * ";
                }
            }
            oddOrEven++;
        }
        if(even == odd)
        {
            Console.WriteLine("Result >> yes << ");
            Console.WriteLine("Product: {0} = {1} = {2}", productOdd, productEven, even);
        }
        else
        {
            Console.WriteLine("Result >> no << ");
            Console.WriteLine("Odd product: {0} = {1}\nEven Product {2} = {3}", productOdd, odd, productEven, even);
        }
    }
}

