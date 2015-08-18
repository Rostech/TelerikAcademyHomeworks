using System;

class FillTheMatrix
{
    /*
      1. Fill the matrix

        Write a program that fills and prints a matrix of size (n, n) 
        as shown below:
     * 
     * a) 	 	 	
            1 	5 	9 	13
            2 	6 	10 	14
            3 	7 	11 	15
            4 	8 	12 	16
        b)   	
            1 	8 	9 	16
            2 	7 	10 	15
            3 	6 	11 	14
            4 	5 	12 	13
        c)    	
            7 	11 	14 	16
            4 	8 	12 	15
            2 	5 	9 	13
            1 	3 	6 	10
        d)*    	
            1 	12 	11 	10
            2 	13 	16 	9
            3 	14 	15 	8
            4 	5 	6 	7

    */

    static void PrintMatrix(int[,] matr)
    {
        for(int row = 0; row < matr.GetLength(0); row++)
        {
            for(int col = 0; col < matr.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matr[row,col]);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int writeNum = 1;
        // A
        Console.WriteLine("\na)\n");
        for(int col = 0; col < n; col++)
        {
            for(int row = 0; row < n; row++)
            {
                matrix[row, col] = writeNum++;
            }
        }
        PrintMatrix(matrix);
        // B
        Console.WriteLine("\nb)\n");
        writeNum = 1;
        for (int col = 0; col < n-1; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = writeNum++;
            }
            col++;
            for(int row = n-1; row >= 0; row--)
            {

                matrix[row, col] = writeNum++;
            }
        }
        PrintMatrix(matrix);
        // C
        Console.WriteLine("\nc)\n");
        int centralNumber = (((n * n) - n + 1) / 2) + 1;
        int numberN = n;
        int tempRow = 0;
        int tempCol = 0;
        int p = 0;
        int tempNum = 0;
        for (int i = 0; i < n; i++)
        {
            matrix[i,i] = centralNumber++;
            tempCol = i-1; tempRow = i+1;
            p = 0;
            tempNum = centralNumber-1;
            while(tempRow < n)
            {
                tempNum += n - p;
                matrix[i, tempRow] = tempNum;
                p++;
                tempRow++;
            }
            p = 0;
            tempNum = centralNumber - 1;
            while(tempCol >= 0)
            {
                tempNum -= n - p;
                matrix[i, tempCol] = tempNum;
                p++;
                tempCol--;
            }
        }
        PrintMatrix(matrix);
        // D
        Console.WriteLine("\nd)\n");
        int move = n;
        int tempMove = move;
        tempCol = 0; tempRow = 0;
        writeNum = 1;
        n *= n;
        while(n > 0)
        {
            // move down
            while(tempMove > 0)
            {
                matrix[tempRow, tempCol] = writeNum++;
                tempRow++;
                tempMove--;
            }
            // move right
            tempMove = --move;
            tempRow--;
            tempCol++;
            while(tempMove > 0)
            {
                matrix[tempRow, tempCol] = writeNum++;
                tempCol++;
                tempMove--;
            }
            // move up
            tempMove = move;
            tempCol--;
            tempRow--;
            while(tempMove > 0)
            {
                matrix[tempRow, tempCol] = writeNum++;
                tempRow--;
                tempMove--;
            }
            // move right
            tempMove = --move;
            tempRow++;
            tempCol--;
            while(tempMove > 0)
            {
                matrix[tempRow, tempCol] = writeNum++;
                tempCol--;
                tempMove--;
            }
            tempRow++;
            tempCol++;
            tempMove = move;
            n--;
        }
        PrintMatrix(matrix);
    }
}

