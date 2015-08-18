namespace WalkInMatrix
{
    internal static class Walk
    {
        private static void ChangeMovementDirection(ref int dx, ref int dy)
        {
            int[] possibleDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] possibleDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;
            int availableDirections = possibleDirectionsX.Length;

            for (int i = 0; i < availableDirections; i++)
            {
                if (possibleDirectionsX[i] == dx && possibleDirectionsY[i] == dy)
                {
                    currentDirection = i;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                dx = possibleDirectionsX[0];
                dy = possibleDirectionsY[0];
                return;
            }

            dx = possibleDirectionsX[currentDirection + 1];
            dy = possibleDirectionsY[currentDirection + 1];
        }

        private static bool FindingAvailableNeighbourCell(int[,] arr, int row, int col)
        {
            int[] possibleDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] possibleDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int availableDirections = possibleDirectionsX.Length;

            for (int i = 0; i < availableDirections; i++)
            {
                if (row + possibleDirectionsX[i] >= arr.GetLength(0) || row + possibleDirectionsX[i] < 0)
                {
                    possibleDirectionsX[i] = 0;
                }

                if (col + possibleDirectionsY[i] >= arr.GetLength(0) || col + possibleDirectionsY[i] < 0)
                {
                    possibleDirectionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[row + possibleDirectionsX[i], col + possibleDirectionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool FindingFreeCells(int[,] matrix, ref int row, ref int col)
        {
            row = 0;
            col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        return true;
                    }
                }
            }

            return false;
        }

        internal static void StartWalking(Matrix matrix)
        {
            int n = matrix.Width;
            int currentNumber = 0, row = 0, col = 0, directionX = 1, directionY = 1;

            while (FindingFreeCells(matrix.MatrixField, ref row, ref col))
            {
                directionX = 1;
                directionY = 1;
                currentNumber++;
                while (true)
                {
                    matrix.MatrixField[row, col] = currentNumber;
                    if (!FindingAvailableNeighbourCell(matrix.MatrixField, row, col))
                    {
                        break;
                    }

                    if (row + directionX >= n || row + directionX < 0 || col + directionY >= n || col + directionY < 0 || matrix.MatrixField[row + directionX, col + directionY] != 0)
                    {
                        while (row + directionX >= n || row + directionX < 0 || col + directionY >= n || col + directionY < 0 || matrix.MatrixField[row + directionX, col + directionY] != 0)
                        {
                            ChangeMovementDirection(ref directionX, ref directionY);
                        }
                    }

                    row += directionX;
                    col += directionY;
                    currentNumber++;
                }
            }
        }
    }
}

