

namespace AnimalHierarchy.Models
{
    using System;
    using System.Linq;
    using AnimalHierarchy.Interfaces;
    using AnimalHierarchy.Enumerations;

    public abstract class Animal : ISound
    {
        private uint age;
        private string name;
        private Sex sex;

        public Animal(uint age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public uint Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("This animal is missing a name!");
                this.name = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public static double AverageAge(Animal[] arr)
        {
            return arr.Average(a => a.Age);
        }

        public abstract string ProduceSount();
    }
}
