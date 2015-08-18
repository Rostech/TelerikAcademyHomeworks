namespace NamingIdentifiers.Task04
{
    using System;
    using System.Collections.Generic;

    internal static class Raiting
    {
        public static void ShowTopPlayers(IList<Player> players)
        {
            Console.WriteLine("\nPoints:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty raiting board!\n");
            }
        }
    }
}
