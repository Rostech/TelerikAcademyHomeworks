using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubtractingPolynomials
{
    /*
        Problem 12. Subtracting polynomials

        Extend the previous program to support also subtraction and multiplication of polynomials.
        */
    static void Main()
    {
        Console.WriteLine("Enter your first polynom coefficients beginning form left to right separated by space: ");
        int[] array1 = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
        Console.WriteLine();
        Console.WriteLine("First polinom is: ");
        PrintPolynomial(array1);

        Console.WriteLine("Enter your first polynom coefficients beginning form left to right separated by space: ");
        int[] array2 = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
        Console.WriteLine();
        Console.WriteLine("Second polinom is: ");
        PrintPolynomial(array2);

        int[] arrResult = Adding(array1, array2);
        Console.WriteLine("The Sum of the polynomials is: ");
        PrintPolynomial(arrResult);

        int[] subtract = Subtraction(array1, array2);
        Console.WriteLine("The Sbtraction of the polynomials is: ");
        PrintPolynomial(subtract);

        int[] multiplication = Multiplication(array1, array2);
        Console.WriteLine("The Sbtraction of the polynomials is: ");
        PrintPolynomial(multiplication);
    }
    static int[] Reverse(int[] array)
    {
        int[] arrReverse = new int[array.Length];
        int j = array.Length - 1;
        for (int i = 0; i < array.Length; i++)
        {
            arrReverse[i] = array[j];
            j--;
        }
        return arrReverse;
    }
    static int[] Adding(int[] arr1, int[] arr2)
    {
        List<int> result = new List<int>();
        arr1 = Reverse(arr1);
        arr2 = Reverse(arr2);
        if (arr1.Length < arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                result.Add(arr1[i] + arr2[i]); ;
            }
            for (int i = arr1.Length; i < arr2.Length; i++)
            {
                result.Add(arr2[i]);
            }
        }
        else if (arr1.Length > arr2.Length)
        {

            for (int i = 0; i < arr2.Length; i++)
            {
                result.Add(arr1[i] + arr2[i]);
            }
            for (int i = arr2.Length; i < arr1.Length; i++)
            {
                result.Add(arr1[i]);
            }
        }
        else
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                result.Add(arr1[i] + arr2[i]);
            }
        }
        result.Reverse();
        return result.ToArray();
    }
    static void PrintPolynomial(int[] arr)
    {
        int j = arr.Length - 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("({0})", arr[i]);
                }
                else
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
            else
            {
                if (arr[i] < 0)
                {
                    Console.Write("({0}) * x^{1} + ", arr[i], j);
                }
                else
                {
                    Console.Write("{0} * x^{1} + ", arr[i], j);
                }

            }
            j--;
        }
        Console.WriteLine();
    }
    static int[] Subtraction(int[] arr1, int[] arr2)
    {
        List<int> result = new List<int>();
        arr1 = Reverse(arr1);
        arr2 = Reverse(arr2);
        if (arr1.Length < arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                result.Add(arr1[i] - arr2[i]); ;
            }
            for (int i = arr1.Length; i < arr2.Length; i++)
            {
                result.Add(arr2[i] * (-1));
            }
        }
        else if (arr1.Length > arr2.Length)
        {

            for (int i = 0; i < arr2.Length; i++)
            {
                result.Add(arr1[i] - arr2[i]);
            }
            for (int i = arr2.Length; i < arr1.Length; i++)
            {
                result.Add(arr1[i]);
            }
        }
        else
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                result.Add(arr1[i] - arr2[i]);
            }
        }
        result.Reverse();
        return result.ToArray();
    }
    static int[] Multiplication(int[] arr1, int[] arr2)
    {
        arr1 = Reverse(arr1);
        arr2 = Reverse(arr2);
        int[] multiplication = new int[arr1.Length + arr2.Length - 1];
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                multiplication[i + j] += arr1[i] * arr2[j];
            }

        }

        multiplication = Reverse(multiplication);
        return multiplication;
    }
}

