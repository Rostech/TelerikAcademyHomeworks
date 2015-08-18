namespace PersonClass
{
    using System;

    public class Person
    {
        private int? age;
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("The age cannot be less than zero");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The name cannot be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("{0}, Age: {1}", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());
        }
    }
}
