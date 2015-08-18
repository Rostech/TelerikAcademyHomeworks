using System;
using System.Linq;

class MaximalSum
{
    /*
        2. Maximal sum

            Write a program that reads a rectangular matrix of 
            size N x M and finds in it the square 3 x 3 that has 
            maximal sum of its elements
    */
    static void Main(string[] args)
    {
        Console.WriteLine(new string('-', 79));
        Console.WriteLine("You should enter a matrix that has at least 3x3 elements!");
        Console.WriteLine(new string('-', 79));
        Console.Write("Enter number of rows in the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of colums in the matrix: ");
        int m = int.Parse(Console.ReadLine());
        string input = string.Empty;
        Console.WriteLine("On each row enter " + m + " elements separated by spaces: ");
        int[,] arr = new int[n,m];
        for(int row = 0; row < n; row++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter elements on row {0}: ", row);
            input = Console.ReadLine();
            string[] strArray = input.Split(' ');
            while (strArray.Length != m)
            {
                Console.Write("Enter {0} elements on row {1}! ", m, row);
                input = Console.ReadLine();
                strArray = input.Split(' ');
            }
            for(int col = 0; col < strArray.Length; col++)
            {
                arr[row, col] = int.Parse(strArray[col]);
            }
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        if(arr.Length < 9)
        {
            Console.WriteLine("\nYour array doesn't have 3x3 subarray!");
            Environment.Exit(0);
        }

        int maxSum = int.MinValue;
        int currentSum = 0;
        int startIndexCol = 0;
        int startIndexRow = 0;
        for (int row = 0; row < arr.GetLength(0)-2; row++)
        {
            currentSum = 0;
            for(int col = 0; col < arr.GetLength(1)-2; col++)
            {
                currentSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2]
                    + arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2]
                    + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];
                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndexCol = col;
                    startIndexRow = row;
                }
            }
        }
        Console.WriteLine("\ninput matrix: ");
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMaximal sum of 3x3 subarray is: " + maxSum);
        Console.WriteLine("The subarray with maximal sum is: ");
        for(int row = startIndexRow; row < startIndexRow + 3; row++)
        {
            for(int col = startIndexCol; col < startIndexCol + 3; col++)
            {
                Console.Write(arr[row,col]+" ");
            }
            Console.WriteLine();
        }
    }
}

