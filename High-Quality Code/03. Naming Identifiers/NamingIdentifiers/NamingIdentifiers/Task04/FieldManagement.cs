namespace NamingIdentifiers.Task04
{
    using System;
    using System.Collections.Generic;

    internal class FieldManagement
    {
        public FieldManagement(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.GeneratePlayField();
            this.SetMines();
        }

        public int Rows { get; set; }

        public int Cols { get; set; }

        public char[,] Field { get; set; }

        public char[,] Mines { get; set; }

        private void GeneratePlayField()
        {
            int boardRows = this.Rows;
            int boardColumns = this.Cols;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            this.Field = board;
        }

        private void SetMines()
        {
            int boardRows = this.Rows;
            int boardColumns = this.Cols;
            char[,] board = new char[boardRows, boardColumns];
            List<int> minesPositions = new List<int>();
            int minesCount = this.Rows + this.Cols;
            int allPositions = this.Rows * this.Cols;

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '-';
                }
            }

            while (minesPositions.Count < minesCount)
            {
                Random random = new Random();
                int randomPosition = random.Next(allPositions);
                if (!minesPositions.Contains(randomPosition))
                {
                    minesPositions.Add(randomPosition);
                }
            }

            foreach (int position in minesPositions)
            {
                int col = position / boardColumns;
                int row = position % boardColumns;
                if (row == 0 && position != 0)
                {
                    col--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            this.Mines = board;
        }
    }
}
