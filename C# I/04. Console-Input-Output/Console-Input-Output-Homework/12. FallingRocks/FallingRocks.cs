using System;
using System.Threading;
using System.Collections.Generic;

struct Element
{
    public int x;
    public int y;
    public string symbol;
    public ConsoleColor color;
}

class FallingRocks
{
    /*
      12.** Falling Rocks

    Implement the "Falling Rocks" game in the text console.
       - A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
       - A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
       - Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system.

     */

    public const int playFieldWidth = 30;
    public const int playFieldHeigth = 20;
    public const int defaultConsoleWidth = 80;
    public const int defaultConsoleHeight = 25;
    public const int defaultBufferWidth = 80;
    public const int defaultBufferHeight = 300;
    public static int liveCounter = 3;
    public static int score = 0;
    // setting the console
    public static void SettingTheConsole(int widht, int height)
    {
        Console.Title = "Falling Rocks";
        Console.WindowWidth = playFieldWidth;
        Console.WindowHeight = playFieldHeigth;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        // remo the cursor
        Console.CursorVisible = false;
    }
    // setting the cursor position
    public static void PrintOnPosition(int x, int y, string symbol, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    } 

    public static void InfoPanel() // info panel borders
    {
        int x = 0;
        int y = 1;
        //PrintOnPosition(x, y); 
        for(int i = 0; i < playFieldWidth; i++)
        {
            PrintOnPosition(x, y, "-");
            x++;
        }
    }

    public static void InfoPanelText(int score, int lives) // info panel text
    {
        PrintOnPosition(1, 0, "Score: ");
        Console.Write(score);
        PrintOnPosition(17, 0, "Lives: ");
        for(int i = 1; i <= lives; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\u2665" + " ");
        }
    }

    

    static void Main()
    {
        // set the playfield
        SettingTheConsole(playFieldWidth, playFieldHeigth);
        // spaceShip
        Element drawf = new Element();
        drawf.x = (playFieldWidth / 2) - 1;
        drawf.y = playFieldHeigth-1;
        drawf.symbol = "(O)";
        // array with different colors
        ConsoleColor[] colorArray = {ConsoleColor.Blue,
            ConsoleColor.DarkGreen, ConsoleColor.Cyan, ConsoleColor.DarkMagenta,
            ConsoleColor.DarkYellow};
        //random generator
        Random randomGenerator = new Random();
        // list with rocks
        List<Element> fallingRocks = new List<Element>();
        //game 
        while (true)
        {
            // create rock
            Element rock = new Element();
            //rock.x = randomGenerator.Next(0, playFieldWidth - 1);
            rock.y = 2;
            rock.symbol = Convert.ToString(Convert.ToChar(Convert.ToInt32(randomGenerator.Next('\u0021', '\u002E'))));
            int symbolLenght = randomGenerator.Next(1, 3);
            while(symbolLenght > 1)
            {
                rock.symbol += rock.symbol;
                symbolLenght--;
            }
            rock.x = randomGenerator.Next(0, playFieldWidth - rock.symbol.Length);
            rock.color = colorArray[randomGenerator.Next(0, colorArray.Length)];
            fallingRocks.Add(rock);
            //Clear the console
            Console.Clear();
            // infoPanel
            InfoPanelText(score, liveCounter);
            InfoPanel();
            // move the spaceship
            while(Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if(pressedKey.Key == ConsoleKey.LeftArrow && drawf.x-1 >= 0)
                {
                    drawf.x--;
                }
                else if(pressedKey.Key == ConsoleKey.RightArrow && drawf.x + 1 < playFieldWidth - drawf.symbol.Length)
                {
                    drawf.x++;
                }
            }
            // print the spaceship
            PrintOnPosition(drawf.x, drawf.y, drawf.symbol);
            // moving rocks
            List<Element> newFallingRocks = new List<Element>();
            for (int index = 0; index < fallingRocks.Count; index++)
            {
                Element oldRock = fallingRocks[index];
                Element newRock = new Element();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.symbol = oldRock.symbol;
                newRock.color = oldRock.color;
                if(newRock.y < playFieldHeigth)
                {
                    newFallingRocks.Add(newRock);
                }
            }
            fallingRocks = newFallingRocks;
            // collision detection
            bool hitted = false;
            for (int i = 0; i < fallingRocks.Count; i++)
            {
                for(int j = 0; j < fallingRocks[i].symbol.Length; j++)
                {
                    for(int g = 0; g < drawf.symbol.Length; g++)
                    {
                        if(fallingRocks[i].y == drawf.y && fallingRocks[i].x + j == drawf.x + g)
                        {
                            hitted = true;
                            break;
                        }
                    }
                    if(hitted)
                    {
                        break;
                    }
                }
                if(hitted)
                {
                    break;
                }
            }
            if(hitted)
            {
                liveCounter--;
            }
            if(liveCounter == -1)
            {
                PrintOnPosition(8, 9, "!GAME OVER!", ConsoleColor.DarkRed);
                PrintOnPosition(5, 10, "Your score is: " + score, ConsoleColor.DarkRed);
                Console.ReadKey();
                Console.WriteLine();
                Environment.Exit(0);
            }
            score += randomGenerator.Next(7, 21);
            foreach (Element fallingRock in fallingRocks)
            {
                PrintOnPosition(fallingRock.x, fallingRock.y, fallingRock.symbol, fallingRock.color);
            }
            // Slow the game
            Thread.Sleep(150);
        }


    }
}

