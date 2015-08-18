

namespace StudentsAndWorkers.Models
{

    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Humans must have first name");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Humans must have last name");
                this.lastName = value;
            }
        }
    }
}
