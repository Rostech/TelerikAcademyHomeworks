namespace SpecificationPattern.ConcreteRules
{
    using SpecificationPattern.BaseLogic;
    using SpecificationPattern.Models;

    public class FearSpecification : ISpecification<Warrior>
    {
        private readonly IWarriorService service;

        public FearSpecification(IWarriorService service)
        {
            this.service = service;
        }

        public bool IsSatisfiedBy(Warrior warrior)
        {
            return this.service.IsAffraidOfWar(warrior);
        }
    }
}
