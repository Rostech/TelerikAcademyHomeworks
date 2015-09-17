namespace DecoratorPattern
{
    using System;

    using DecoratorPattern.Decorators;
    using DecoratorPattern.Models;

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a human
            Human baby = new Boy("Stamat");
            Console.WriteLine(baby.Introduce());
            Console.WriteLine(new string('-', 60));

            // Human is learning to walk
            var walkableBaby = new Walkable(baby);
            Console.WriteLine(walkableBaby.Introduce());
            Console.WriteLine(new string('-', 60));

            // Human is learning to talk
            var talkableBaby = new Talkable(walkableBaby);
            Console.WriteLine(talkableBaby.Introduce());
            Console.WriteLine(new string('-', 60));

            // Human is learning to eat by it's self
            var selfFeedableBaby = new SelfFeedable(talkableBaby);
            Console.WriteLine(selfFeedableBaby.Introduce());
            Console.WriteLine(new string('-', 60));
        }
    }
}
