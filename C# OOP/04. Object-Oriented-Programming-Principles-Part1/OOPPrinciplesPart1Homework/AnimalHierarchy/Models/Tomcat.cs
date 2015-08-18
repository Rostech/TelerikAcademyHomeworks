

namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Enumerations;

    class Tomcat : Cat
    {
        public Tomcat(uint age, string name)
            : base(age, name, Sex.Male)
        {

        }


    }
}
