using System;
using System.Text;

class SequenceNMatrix
{
    /*
     3. Sequence n matrix

        We are given a matrix of strings of size N x M. Sequences in 
        the matrix we define as sets of several neighbour elements 
        located on the same line, column or diagonal.
        Write a program that finds the longest sequence of equal 
        strings in the matrix.
     
    */

    static void Main()
    {
        Console.Write("Enter number of rows in the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of colums in the matrix: ");
        int m = int.Parse(Console.ReadLine());
        string input = string.Empty;
        Console.WriteLine("On each row enter " + m + " elements separated by spaces: ");
        string[,] arr = new string[n, m];
        StringBuilder appendResult = new StringBuilder();
        string result = string.Empty;
        for (int row = 0; row < n; row++)
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
            for (int col = 0; col < strArray.Length; col++)
            {
                arr[row, col] = strArray[col];
            }
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        int tempRow = 0, tempCol = 0;
        int maxSum = 0, tempSum = 0;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                tempRow = row; tempCol = col;
                tempSum = 0;
                // check vertical
                while(tempRow < arr.GetLength(0)-1)
                {
                    if(!string.Equals(arr[tempRow, tempCol], arr[tempRow+1, tempCol]))
                    {
                        break;
                    } 
                    tempSum++;
                    tempRow++;
                    appendResult.Append(arr[tempRow, tempCol]);
                    appendResult.Append(" ");
                }
                if(tempSum >= maxSum)
                {
                    appendResult.Append(arr[tempRow, tempCol]);
                    maxSum = tempSum;
                    result = appendResult.ToString();
                    appendResult.Clear();
                }
                tempRow = row;
                tempSum = 0;
                // check horisontal
                while(tempCol < arr.GetLength(1)-1)
                {
                    if(!string.Equals(arr[tempRow, tempCol], arr[tempRow, tempCol+1]))
                    {
                        break;
                    }
                    tempCol++;
                    tempSum++;
                    appendResult.Append(arr[tempRow, tempCol]);
                    appendResult.Append(" ");
                }
                if (tempSum >= maxSum)
                {
                    appendResult.Append(arr[tempRow, tempCol]);
                    maxSum = tempSum;
                    result = appendResult.ToString();
                    appendResult.Clear();
                }
                tempCol = col;
                tempSum = 0;
                //check diagonal
                while (tempCol < arr.GetLength(1) - 1 && tempRow < arr.GetLength(0) - 1)
                {
                    if (!string.Equals(arr[tempRow, tempCol], arr[tempRow + 1, tempCol + 1]))
                    {
                        break;
                    }
                    tempCol++;
                    tempRow++;
                    tempSum++;
                    appendResult.Append(arr[tempRow, tempCol]);
                    appendResult.Append(" ");
                } 
                if (tempSum >= maxSum)
                {
                    appendResult.Append(arr[tempRow, tempCol]);
                    maxSum = tempSum;
                    result = appendResult.ToString();
                    appendResult.Clear();
                }
            }
        }
        appendResult.Clear();
        Console.WriteLine("{0,-" + (arr.GetLength(1) + 10) + "} {1}", "matrix", "result");
        for(int row = 0; row < arr.GetLength(0); row++)
        {
            for(int col = 0; col < arr.GetLength(1); col++)
            {
                appendResult.Append(arr[row, col]);
                appendResult.Append(" ");
            }
            Console.WriteLine("{0,-" + (arr.GetLength(1) + 10) + "} {1}", appendResult.ToString(), row == 0 ? string.Join(", ", result.Split(' ')) : " ");
            appendResult.Clear();
        }
    }
}

