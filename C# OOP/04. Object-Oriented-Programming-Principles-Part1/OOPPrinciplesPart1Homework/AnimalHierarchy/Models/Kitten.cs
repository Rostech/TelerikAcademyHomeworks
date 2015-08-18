

namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Enumerations;

    class Kitten : Cat
    {
        
        public Kitten(uint age, string name)
            : base(age, name, Sex.Female)
        {

        }

        
    }
}
