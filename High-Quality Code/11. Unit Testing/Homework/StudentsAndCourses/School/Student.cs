namespace School
{
    using System;

    public class Student
    {
        private const int MinId = 10000;
        private const int MaxId = 99999;
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if(value < MinId || MaxId < value)
                {
                    throw new ArgumentException(String.Format("The id has to be {0} <= id <= {1}", MinId, MaxId));
                }

                this.id = value;
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
                if(value == null || value == string.Empty)
                {
                    throw new ArgumentException("The name of the student can not be null or empty string");
                }

                this.name = value;
            }
        }

        public void EnrollCourse(Course course)
        {
            if(course == null)
            {
                throw new ArgumentException("Course can not be null.");
            }

            course.AddStudent(this);
        }

        public void UnsubscribeCourse(Course course)
        {
            if (course == null)
            {
                throw new InvalidOperationException("Course can not be null.");
            }
            
            course.RemoveStudent(this);
        }
    }
}
