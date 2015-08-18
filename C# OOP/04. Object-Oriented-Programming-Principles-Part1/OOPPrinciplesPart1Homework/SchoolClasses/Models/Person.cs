
namespace SchoolClasses.Models
{
    using System;

    public abstract class Person
    {

        public string Name { get; private set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Talk()
        {
            return String.Format("My name is {0}", this.Name);
        }
    }
}
