namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private ICollection<Student> students;
        private ICollection<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if(value == null || value == string.Empty)
                {
                    throw new ArgumentException("The schools name can not be null or empty.");
                }

                name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(students);
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(courses);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can not be null.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already exists.");
            }

            if (this.students.Any(st => st.Id == student.Id))
            {
                throw new InvalidOperationException("There is already a student with the same Id.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can not be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("This student does not exists.");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course can not be null.");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course already exists.");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course doesn't exists.");
            }

            this.courses.Remove(course);
        }
    }
}
