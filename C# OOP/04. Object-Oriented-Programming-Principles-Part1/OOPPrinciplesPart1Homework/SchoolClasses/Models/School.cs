

namespace SchoolClasses.Models
{
    using System.Collections.Generic;

    class School
    {
        private HashSet<Class> setOfClasses;

        public School(params Class[] classes)
        {
            this.setOfClasses = new HashSet<Class>();
            foreach(var cls in classes)
            {
                this.setOfClasses.Add(cls);
            }
        }

        private HashSet<Class> SetOfClasses
        {
            get
            {
                return this.setOfClasses;
            }
        }

        public void AddClass(Class newClass)
        {
            this.setOfClasses.Add(newClass);
        }

        public void RemoveClass(Class newClass)
        {
            this.setOfClasses.Remove(newClass);
        }

        public override string ToString()
        {
            return string.Format("\nSchool:\n {0}", string.Join("\n", this.SetOfClasses ));
        }
    }
}
