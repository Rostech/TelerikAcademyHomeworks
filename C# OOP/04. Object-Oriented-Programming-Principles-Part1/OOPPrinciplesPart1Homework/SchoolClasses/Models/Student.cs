

namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using SchoolClasses.Interfaces;

    class Student : Person, IComment
    {
        private string uniqueClassNumber;
        private List<string> comment;

        public Student(string name, string uniqueClNumber)
            :base (name)
        {
            this.comment = new List<string>();
            this.UniqueClassNumber = uniqueClNumber;
        }

        public string UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            private set 
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("This student is missing unique class number!");
                }
                this.uniqueClassNumber = value;
            }
        }

        public List<string> Comment
        {
            get { return this.comment; }
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
            return string.Format("          Student: {0} ID: {1} {2}\n\n", this.Name, this.uniqueClassNumber, 
                this.Comment.Count > 0 ? string.Format("\n             Comments: \n               {0}", 
                string.Join("\n               ", this.Comment)) : "\n");
        }
    }
}
