using System;

class LargestAreaInMatrix
{
    /*
       7.* Largest area in matrix

        Write a program that finds the largest area of equal neighbour 
        elements in a rectangular matrix and prints its size.

                Example:
                matrix 	                    result
                1 	3 	2 	2 	2 	4           13
                3 	3 	3 	2 	4 	4
                4 	3 	1 	2 	3 	3
                4 	3 	1 	3 	3 	1
                4 	3 	3 	3 	1 	1
	
    */
    static void Main()
    {
        int[,] matrix = {
                       {1,3,2,2,2,4},
                       {3,3,3,2,4,4},
                       {4,3,1,2,3,3},
                       {4,3,1,3,3,1},
                       {4,3,3,3,1,1}
                       };

        int current = 0;
        int max = 0;
        for(int row = 0; row<matrix.GetLength(0); row++)
        {
            for(int col = 0; col < matrix.GetLength(1); row++)
            {

            }
        }
    }
}

