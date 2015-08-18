namespace NamingIdentifiers.Task04
{
    using System;

    internal static class Renderer
    {
        public static void GameField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            string colNumbers = string.Empty;
            string horisontalLine = string.Empty;

            for (int i = 0; i < cols; i++)
            {
                colNumbers += " " + i.ToString();
                horisontalLine += "--";
            }

            Console.WriteLine("\n   " + colNumbers);
            Console.WriteLine("   " + horisontalLine);
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   " + horisontalLine);
        }
    }
}
