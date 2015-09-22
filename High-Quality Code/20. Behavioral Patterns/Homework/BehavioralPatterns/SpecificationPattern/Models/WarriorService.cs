namespace SpecificationPattern.Models
{
    using System;
    using System.Collections.Generic;

    public class WarriorService : IWarriorService
    {
        private const int IncludeWarriorInArmyHealthCriteria = 60;
        private const int IncludeWarriorInArmyStrengthCriteria = 20;
        private const bool IncludeWarriorInArmyIsAffraidCriteria = false;

        private readonly ICollection<Warrior> warriors;

        public WarriorService(int count = 30)
        {
            this.warriors = new List<Warrior>();
            Random rand = new Random();
            for(int i = 0; i <= count; i++)
            {
                Warrior warrior = new Warrior()
                {
                    Id = i,
                    IsAffraid = false
                };
                warrior.Health = rand.Next(0, 100);
                warrior.Strength = rand.Next(0, 100);

                if (rand.Next(0, 2) == 1)
                {
                    warrior.IsAffraid = true;
                }

                this.warriors.Add(warrior);
            }
        }

        public IEnumerable<Warrior> GetAllWarriors()
        {
            return this.warriors;
        }

        public bool IsHealthyEnoughtForWar(Warrior warrior)
        {
            return warrior.Health >= IncludeWarriorInArmyHealthCriteria;
        }

        public bool IsStrongEnoughtForWar(Warrior warrior)
        {
            return warrior.Strength >= IncludeWarriorInArmyStrengthCriteria;
        }

        public bool IsAffraidOfWar(Warrior warrior)
        {
            return warrior.IsAffraid == IncludeWarriorInArmyIsAffraidCriteria;
        }
    }
}
