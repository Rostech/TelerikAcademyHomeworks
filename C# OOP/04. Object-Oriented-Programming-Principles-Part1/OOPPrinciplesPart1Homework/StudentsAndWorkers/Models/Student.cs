

namespace StudentsAndWorkers.Models
{
    using System;

    class Student : Human
    {
        private byte grade;

        public Student(string fname, string lname, byte grade)
            :base(fname, lname)
        {
            this.Grade = grade;
        }

        public byte Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Students have 1 to 12 grades!");
                this.grade = value;
            }
        }
    }
}
