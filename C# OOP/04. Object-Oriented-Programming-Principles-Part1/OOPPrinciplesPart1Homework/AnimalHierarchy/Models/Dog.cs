
namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Enumerations;

    class Dog : Animal
    {
        public Dog(uint age, string name, Sex sex)
            :base (age, name, sex)
        {

        }

        public override string ProduceSount()
        {
            return string.Format("({0}) Bau bau bauuu said {1}", this.GetType().Name, this.Name); 
        }
    }
}
