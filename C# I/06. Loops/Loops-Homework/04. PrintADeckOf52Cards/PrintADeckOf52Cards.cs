﻿using System;

class PrintADeckOf52Cards
{
    /*
      4. Print a Deck of 52 Cards

        Write a program that generates and prints all possible cards from a 
        standard deck of 52 cards (without the jokers). The cards should be 
        printed using the classical notation (like 5 of spades, A of hearts, 
        9 of clubs; and K of diamonds).
            - The card faces should start from 2 to A.
            - Print each card face in its four possible suits: clubs, 
              diamonds, hearts and spades. Use 2 nested for-loops and a 
              switch-case statement.

    */
    static void Main()
    {
        string[] cardName = {"2", "3", "4", "5", "6", "7", "8", "9",
                            "10", "J", "Q", "K", "A"};
        for(int i = 0; i < cardName.Length; i++)
        {
            for(int j = 1; j <= 4; j++)
            {
                Console.Write("{0} of ", cardName[i]);
                switch(j)
                {
                    case 1:
                        Console.Write("spades");
                        break;
                    case 2:
                        Console.Write("clubs");
                        break;
                    case 3:
                        Console.Write("hearts");
                        break;
                    case 4:
                        Console.Write("diamonds");
                        break;
                    default:
                        break;
                }
                if(j < 4)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

