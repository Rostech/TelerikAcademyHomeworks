namespace SpecificationPattern.Models
{
    using System.Collections.Generic;

    public interface IWarriorService
    {
        IEnumerable<Warrior> GetAllWarriors();

        bool IsHealthyEnoughtForWar(Warrior warrior);

        bool IsStrongEnoughtForWar(Warrior warrior);

        bool IsAffraidOfWar(Warrior warrior);
    }
}
