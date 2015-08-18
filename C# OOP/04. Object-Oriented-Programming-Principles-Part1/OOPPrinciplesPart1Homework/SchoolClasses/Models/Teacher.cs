

namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using SchoolClasses.Interfaces;

    class Teacher : Person, IComment
    {
        private HashSet<Discipline> setOfDisciplines;
        private List<string> comment;

        public Teacher(string name, params Discipline[] disciplines)
            :base (name)
        {
            HashSet<Discipline> testSet = new HashSet<Discipline>();
            foreach (var t in disciplines)
            {
                testSet.Add(t);
            }
            this.SetOfDisciplines = testSet;
            this.comment = new List<string>();
        }

        public HashSet<Discipline> SetOfDisciplines
        {
            get { return this.setOfDisciplines; }
            private set
            {
                if (value.Count < 1)
                    throw new ArgumentException("This teacher should teach at least one discipline!");
                this.setOfDisciplines = value;
            }
        }

        public void AddDiscipline(Discipline dis)
        {
            this.setOfDisciplines.Add(dis);
        }

        public void RemoveDisciplne(Discipline dis)
        {
            this.setOfDisciplines.Remove(dis);
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
            return string.Format("           Teacher -  {0}\n {1}\n", this.Name, string.Join(" ", this.SetOfDisciplines));
        }
        
    }
}
