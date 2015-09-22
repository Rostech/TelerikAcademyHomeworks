namespace SpecificationPattern
{
    using System;

    using SpecificationPattern.Models;
    using SpecificationPattern.ConcreteRules;
    using SpecificationPattern.Utils;

    public class Program
    {
        static void Main(string[] args)
        {
            var warriorService = new WarriorService();

            var strenght = new StrenghtSpecification(warriorService);
            var health = new HealthSpecification(warriorService);
            var fear = new FearSpecification(warriorService);

            var availableForWar = health.And(strenght).And(fear);
            foreach(var warrior in warriorService.GetAllWarriors())
            {
                if(availableForWar.IsSatisfiedBy(warrior))
                {
                    Console.WriteLine(warrior);
                }
            }
        }
    }
}
