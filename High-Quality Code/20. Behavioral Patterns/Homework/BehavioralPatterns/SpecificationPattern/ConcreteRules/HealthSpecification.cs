namespace SpecificationPattern.ConcreteRules
{
    using SpecificationPattern.BaseLogic;
    using SpecificationPattern.Models;

    public class HealthSpecification : ISpecification<Warrior>
    {
        private readonly IWarriorService service;

        public HealthSpecification(IWarriorService service)
        {
            this.service = service;
        }

        public bool IsSatisfiedBy(Warrior warrior)
        {
            return this.service.IsHealthyEnoughtForWar(warrior);
        }
    }
}
