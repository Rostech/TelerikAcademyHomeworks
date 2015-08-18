

namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Enumerations;

    class Frog : Animal
    {
         public Frog(uint age, string name, Sex sex)
            :base (age, name, sex)
        {

        }

        public override string ProduceSount()
        {
            return string.Format("({0}) Kwa kwa kwa said {1}", this.GetType().Name, this.Name); 
        }
    }
}
