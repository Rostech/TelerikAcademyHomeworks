

namespace SchoolClasses.Models
{
    using System;
    using SchoolClasses.Interfaces;
    using System.Collections.Generic;

    class Discipline : IComment
    {
        private string name;
        private byte numberOfLectures;
        private byte numberOfExercises;
        private List<string> comment;
        

        public Discipline( string name, byte numLec, byte numExer)
        {
            this.Name = name;
            this.NumberOfLectures = numLec;
            this.NumberOfExercises = numExer;
            this.comment = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The discipline has to have a name!");
                this.name = value;
            }
        }
        public byte NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 1)
                    throw new Exception("There has to be atleast one lecure!");
                this.numberOfLectures = value;
            }
        }
        public byte NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 1)
                    throw new Exception("There has to be atleast one exercise!");
                this.numberOfExercises = value;
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
            return string.Format("              - {0}, {1} lectures, {2} exercises\n", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
