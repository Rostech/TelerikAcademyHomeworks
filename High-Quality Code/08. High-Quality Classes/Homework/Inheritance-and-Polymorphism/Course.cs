namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public IList<string> Students { get; set; }

        public Course(string name)
            : this(name, null)
        {
        }

        public Course(string name, string teacherName)
            : this (name, teacherName, null)
        {
        }

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            string[] courseTypeUtils = CourseType();
            StringBuilder result = new StringBuilder();
            result.Append(courseTypeUtils[0]);
            result.Append(" { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (courseTypeUtils.Length == 2)
            {
                result.Append("; ");
                result.Append(courseTypeUtils[1]);
                result.Append("= ");
                result.Append(courseTypeUtils[1]);
            }

            result.Append(" }");
            return result.ToString();
        }

        /// <summary>
        /// Returns an array. First value is the course name, the second ( if has one) is value of Town or Teachers needed for 
        /// the explanation
        /// </summary>
        /// <returns>Array</returns>
        protected abstract string[] CourseType();
    }
}
