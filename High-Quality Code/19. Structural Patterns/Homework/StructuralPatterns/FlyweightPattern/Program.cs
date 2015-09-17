namespace FlyweightPattern
{
    using FlyweightPattern.Factories;
    using FlyweightPattern.Models;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            const string Terrorist = "terrorist";
            const string Cop = "cop";

            List<Soldier> terroristArmy = new List<Soldier>();
            List<Soldier> copArmy = new List<Soldier>();

            var soldierFactory = new SoldierFactory();

            for (int i = 0; i < 5; i++)
            {
                terroristArmy.Add(soldierFactory.GetSoldier(Terrorist));
                copArmy.Add(soldierFactory.GetSoldier(Cop));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(terroristArmy[i].SoldierInfo(i));
                Console.WriteLine(copArmy[i].SoldierInfo(i));
            }

            Console.WriteLine(new string('/', 60));
            Console.WriteLine("Total objects created: {0}", soldierFactory.NumberOfObjects);
            Console.WriteLine(new string('/', 60));
        }
    }
}
