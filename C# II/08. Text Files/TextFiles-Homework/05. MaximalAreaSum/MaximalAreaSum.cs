using System;
using System.IO;

class MaximalAreaSum
{
    /*
     5. Maximal area sum

        Write a program that reads a text file containing a square matrix 
        of numbers.
        Find an area of size 2 x 2 in the matrix, with a maximal sum of 
        its elements.
          - The first line in the input file contains the size of matrix N.
          - Each of the next N lines contain N numbers separated by space.
          - The output should be a single number in a separate text file.

                Example:
                input 	  output
                4         17
                2 3 3 4
                0 2 3 4
                3 7 1 2
                4 3 3 2 	
    */
    static void Main()
    {
        string file = @"..\..\..\Files\matrix05Task.txt";
        string newFile = @"..\..\..\Files\matrix05TaskResult.txt";
        try
        {
            StreamReader readFile = new StreamReader(file);
            StreamWriter writeFile = new StreamWriter(newFile);
            using(writeFile)
            {
                int result = 0;
                using(readFile)
                {
                    string line = readFile.ReadLine();
                    int[,] matrix = new int[int.Parse(line), int.Parse(line)];
                    line = readFile.ReadLine();
                    int row = 0;
                    while(line != null)
                    {
                        int[] lineWithNumbers = Array.ConvertAll(line.Trim().Split(), int.Parse);
                        for(int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = lineWithNumbers[col];
                        }
                        row++;
                        line = readFile.ReadLine();
                    }
                    for (row = 0; row < matrix.GetLength(0)-1; row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1)-1; col++)
                        {
                            int currentResult = matrix[row, col] + matrix[row + 1, col] +
                                matrix[row, col + 1] + matrix[row + 1, col + 1];
                            if (currentResult > result)
                                result = currentResult;
                        }
                    }
                }
                writeFile.WriteLine(result);
            }
            Console.WriteLine("Success. The result is in \"matrix05TaskResult.txt\"");
        }
        catch(FormatException)
        {
            Console.WriteLine("Not a number!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not found!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path!");
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("The directory is not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Oops. Something went wrong!");
        }
    }
}

