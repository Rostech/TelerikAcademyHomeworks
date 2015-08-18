namespace NamingIdentifiers.Task04
{
    using System;
    using System.Collections.Generic;

    public class MinesGame
    {
        public static void Engine()
        {
            FieldManagement gameField = new FieldManagement(5, 10);
            string gameCommand = string.Empty;
            char[,] field = gameField.Field;
            char[,] mines = gameField.Mines;
            int row = 0;
            int col = 0;
            int countMoves = 0;
            int maks = (gameField.Rows * gameField.Cols) - (gameField.Rows + gameField.Cols);
            bool startGame = true;
            bool winGame = false;
            bool explosion = false;
            List<Player> topPlayers = new List<Player>();

            do
            {
                if (startGame)
                {
                    Console.WriteLine("Lets play \"Minesweeper\". Try your luck to find the boxes without mines in them." +
                    " Command 'top' shows the raiting board, 'restart' restarts the game, 'exit' exits the game!");
                    Renderer.GameField(field);
                    startGame = false;
                }

                Console.Write("Enter row and column: ");
                gameCommand = Console.ReadLine().Trim();
                if (gameCommand.Length >= 3)
                {
                    if (int.TryParse(gameCommand[0].ToString(), out row) &&
                        int.TryParse(gameCommand[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        gameCommand = "turn";
                    }
                }

                switch (gameCommand)
                {
                    case "top":
                        Raiting.ShowTopPlayers(topPlayers);
                        break;
                    case "restart":
                        field = gameField.Field;
                        mines = gameField.Mines;
                        Renderer.GameField(field);
                        explosion = false;
                        startGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                ShowMinesAround(field, mines, row, col);
                                countMoves++;
                            }

                            if (maks == countMoves)
                            {
                                winGame = true;
                            }
                            else
                            {
                                Renderer.GameField(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError. Invalid command! \n");
                        break;
                }

                if (explosion)
                {
                    Renderer.GameField(mines);
                    Console.Write("\nHrrrrrr! Dies like a hero with {0} points. " +
                        "Enter yout nickname: ", countMoves);
                    string niknejm = Console.ReadLine();
                    Player t = new Player(niknejm, countMoves);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < t.Points)
                            {
                                topPlayers.Insert(i, t);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    topPlayers.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    Raiting.ShowTopPlayers(topPlayers);
                    field = gameField.Field;
                    mines = gameField.Mines;
                    countMoves = 0;
                    explosion = false;
                    startGame = true;
                }

                if (winGame)
                {
                    Console.WriteLine("\nBRAVOOOS! You won.");
                    Renderer.GameField(field);
                    Console.WriteLine("Enter your nickname: ");
                    string imeee = Console.ReadLine();
                    Player to4kii = new Player(imeee, countMoves);
                    topPlayers.Add(to4kii);
                    Raiting.ShowTopPlayers(topPlayers);
                    field = gameField.Field;
                    mines = gameField.Mines;
                    countMoves = 0;
                    winGame = false;
                    startGame = true;
                }
            }
            while (gameCommand != "exit");

            Console.WriteLine("Made in Bulgaria \n(by very good developers)!");
            Console.Read();
        }

        private static void ShowMinesAround(char[,] field, char[,] mines, int row, int col)
        {
            char nearMinesCount = CountMinesAround(mines, row, col);
            field[row, col] = nearMinesCount;
        }

        private static char CountMinesAround(char[,] mines, int row, int col)
        {
            int count = 0;
            int reds = mines.GetLength(0);
            int kols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < reds)
            {
                if (mines[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < kols)
            {
                if (mines[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < kols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < reds) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < reds) && (col + 1 < kols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
