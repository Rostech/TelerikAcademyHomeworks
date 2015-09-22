namespace SpecificationPattern.ConcreteRules
{
    using SpecificationPattern.BaseLogic;
    using SpecificationPattern.Models;

    public class StrenghtSpecification : ISpecification<Warrior>
    {
        private readonly IWarriorService service;

        public StrenghtSpecification(IWarriorService service)
        {
            this.service = service;
        }

        public bool IsSatisfiedBy(Warrior warrior)
        {
            return this.service.IsStrongEnoughtForWar(warrior);
        }
    }
}
