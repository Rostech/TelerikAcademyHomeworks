

namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Enumerations;

    class Cat : Animal
    {
        public Cat(uint age, string name, Sex sex)
            : base(age, name, sex)
        {

        }

        public override string ProduceSount()
        {
            return string.Format("({0}) Meow meow said {1}", this.GetType().Name, this.Name);
        }
    }
}
