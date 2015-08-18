using System;

class SpiralMatrix
{
    /*
      19.** Spiral Matrix

        Write a program that reads from the console a positive integer
        number n (1 = n = 20) and prints a matrix holding the numbers 
        from 1 to n*n in the form of square spiral like in the examples 
        below.

        n = 2   matrix      n = 3   matrix      n = 4   matrix
                1 2                 1 2 3               1  2  3  4
                4 3                 8 9 4               12 13 14 5
                                    7 6 5               11 16 15 6
                                                        10 9  8  7
    */
    static void Main()
    {
        Console.Title = "Spiral Matrix";
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int index = 1;
        int[,] arr = new int[n,n];
        int row = 0, col = 0;
        int right = n, down = n-1, left = 0, up = 1;
        int counter = 1;
        while(index <= n*n)
        {
            while(col < right)
            {
                arr[row, col] = index;
                col++;
                index++;
            }
            col--;
            while (row < down)
            {
                row++;
                arr[row, col] = index;
                index++;
            }
            while(col > left)
            {
                col--;
                arr[row, col] = index;
                index++;
            }
            while(row > up)
            {
                row--;
                arr[row, col] = index;
                index++;
            }
            right--;
            down--;
            left++;
            up++; ;
            row = counter;
            col = counter;
            counter++;
        }
        int space = 3;
        if(n < 9)
        {
            space = 3;
        }
        else
        {
            space = 4;
        }
        Console.WriteLine("\nResult:\n\n");
        string format = "{0,-" + space + "}";
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(format,arr[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

