namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsCount = 30;
        private ICollection<Student> students;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("The course name can not be null or empty!");
                }

                name = value;
            }
        }

        internal ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException("Student can not be null.");
            }

            if(this.Students.Count + 1 > MaxStudentsCount)
            {
                throw new InvalidOperationException("The students list for this course is full.");
            }

            if(this.Students.Contains(student))
            {
                throw new InvalidOperationException("This student already exists in that course.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can not be null.");
            }

            if (!this.Students.Contains(student))
            {
                throw new InvalidOperationException("This student does not exists in that course.");
            }

            this.students.Remove(student);
        }
    }
}
