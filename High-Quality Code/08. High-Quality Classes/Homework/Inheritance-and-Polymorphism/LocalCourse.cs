namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string courseName)
            :   this(courseName, null)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            :base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        //public override string ToString()
        //{
        //    StringBuilder result = new StringBuilder();
        //    result.Append("LocalCourse { Name = ");
        //    result.Append(this.Name);
        //    if (this.TeacherName != null)
        //    {
        //        result.Append("; Teacher = ");
        //        result.Append(this.TeacherName);
        //    }
        //    result.Append("; Students = ");
        //    result.Append(base.GetStudentsAsString());
        //    if (this.Lab != null)
        //    {
        //        result.Append("; Lab = ");
        //        result.Append(this.Lab);
        //    }
        //    result.Append(" }");
        //    return result.ToString();
        //}

        protected override string[] CourseType()
        {
            List<string> courseUtils = new List<string>();
            courseUtils.Add("LocalCourse");
            if (this.Lab != null)
            {
                courseUtils.Add("; Lab = " + this.Lab);
            }

            return courseUtils.ToArray();
        }
    }
}
