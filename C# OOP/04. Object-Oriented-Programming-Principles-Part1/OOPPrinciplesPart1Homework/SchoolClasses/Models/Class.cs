
namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using SchoolClasses.Interfaces;

    class Class : IComment
    {
        private HashSet<Teacher> setOfTeacher;
        private HashSet<Student> setOfStudents;
        private List<string> comment;
        private string uniqueTextID;

        public Class(string uniqueTID, params Teacher[] teachers)
        {
            this.comment = new List<string>();
            this.UniqueTextID = uniqueTID;
            setOfStudents = new HashSet<Student>();
            HashSet<Teacher> testSet = new HashSet<Teacher>();
            foreach (var t in teachers)
            {
                testSet.Add(t);
            }
            this.SetOfTeachers = testSet;
        }

        public string UniqueTextID
        {
            get { return this.uniqueTextID; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Class is missing unique text id!");
                this.uniqueTextID = value;
            }
        }

        public HashSet<Teacher> SetOfTeachers
        {
            get
            {
                return this.setOfTeacher;
            }
            set
            {
                if (value.Count < 1)
                    throw new ArgumentException("This calss has to have at least one teacher!");
                this.setOfTeacher = value;
            }
        }

        public HashSet<Student> SetOfStudents
        {
            get
            {
                return this.setOfStudents;
            }
        }

        public List<string> Comment
        {
            get { return this.comment; }
        }

        public void AddStudents(params Student[] students)
        {
            foreach(var s in students)
            {
                this.setOfStudents.Add(s);
            }
        }

        public void RemoveStudent(Student student)
        {
            this.setOfStudents.Remove(student);
        }

        public void AddComment(string addText)
        {
            this.comment.Add(addText);
        }

        public void DeleteComents()
        {
            this.Comment.Clear();
        }

        public override string ToString()
        {
            return string.Format("\n    Class {0} : \n      - Teachers: \n{1} \n      - Students: \n{2}\n",this.UniqueTextID, string.Join("" , this.SetOfTeachers), this.SetOfStudents.Count != 0 ? string.Join("" ,this.SetOfStudents) : "\n       - no students yet!");
        }
    }
}
