namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string courseName)
            : this(courseName, null)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = null; // test is town is accessed
        }

        //public override string ToString()
        //{
        //    StringBuilder result = new StringBuilder();
        //    result.Append(this.DoDo());
        //    result.Append("OffsiteCourse { Name = ");
        //    result.Append(this.Name);
        //    result.Append("\n");
        //    result.Append(typeof(OffsiteCourse).Name);

        //    result.Append("\n");
        //    if (this.TeacherName != null)
        //    {
        //        result.Append("; Teacher = ");
        //        result.Append(this.TeacherName);
        //    }
        //    result.Append("; Students = ");
        //    result.Append(this.GetStudentsAsString());
        //    if (this.Town != null)
        //    {
        //        result.Append("; Town = ");
        //        result.Append(this.Town);
        //    }
        //    result.Append(" }");
        //    return result.ToString();
        //}


        protected override string[] CourseType()
        {
            List<string> courseUtils = new List<string>();
            courseUtils.Add("OffsiteCourse");
            if(this.Town != null)
            {
                courseUtils.Add("; Town = " + this.Town);
            }

            return courseUtils.ToArray();
        }
    }
}
