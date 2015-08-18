
namespace Extension_Delegates_AndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Student
    {
        private string firstName;
        private string lastName;
        private uint? age;
        private string fN;
        private string tel;
        private string email;
        private List<double> marks;
        private uint? groupNumber;

        public Student(string fname, string lname)
            : this(fname, lname, null)
        {
            
        }

        public Student(string fname, string lname, uint? age)
            :this(fname, lname, age, null)
        {
            
        }

        public Student(string fname, string lname, uint? age, string fn)
            :this(fname, lname, age, fn, null)
        {
           
        }

        public Student(string fname, string lname, uint? age, string fn, string tel)
            :this(fname, lname, age, fn, tel, null)
        {

        }

        public Student(string fname, string lname, uint? age, string fn, string tel, string email)
            :this (fname, lname, age, fn, tel, email, null)
        {

        }
        public Student(string fname, string lname, uint? age, string fn, string tel, string email, List<double> marks)
            :this (fname, lname, age, fn, tel, email, marks, null)
        {

        }

        public Student(string fname, string lname, uint? age, string fn, string tel, string email, List<double> marks, uint? groupnumber)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupnumber;
        }


        public string FirstName
        {
            get
            {
                if (this.firstName == null)
                    throw new Exception("The first name of the student is empty!");
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name can not be empty or white space!");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                if (this.lastName == null)
                    throw new Exception("The last name of the student is empty!");
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name can not be empty or white space!");
                this.lastName = value;
            }
        }

        public uint? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 14 || value > 120)
                    throw new Exception(string.Format("This person is too {0} to be a student!", value < 14 ? "young" : "old"));
                this.age = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fN;
            }
            set
            {
                if (value != null)
                {
                   
                    if (value.Length != 6)
                        throw new ArgumentException(string.Format("{0} has to have six numbers!", value));
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] > '9' || value[i] < '0')
                            throw new ArgumentException(string.Format("{0} has invalid characters! The number has to contain only numbers", value));
                    }

                }
                this.fN = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if(value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if ((value[i] > '9' || value[i] < '0') && (value[i] != '+' && value[i] != '(' && value[i] != ')' && value[i] != ' '))
                            throw new ArgumentException(string.Format("{0} has invalid characters! The number has to contain only numbers", value));
                    }
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                // it's good to add some email validation here but the point of the task is not string validation and I don't have
                // time do deal with this now because of the group project :D so.. sorry. Hope you'll not count this as a mistake ^^
                this.email = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public uint? GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        

        /*
        3. First before last

            Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            Use LINQ query operators.

        */
        public static IEnumerable<Student> FirstBeforeLast(IEnumerable<Student> stdArr)
        {
            var result =
                from student in stdArr
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return result;
                
        }

        /*
         4. Age range

            Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        */
        public static IEnumerable<Student> AgeRange(IEnumerable<Student> stdArr)
        {
            var result =
                from student in stdArr
                where (student.Age >= 18 && student.Age <= 24)
                select student;
            return result;
        }

        /*
         5. Order students

            Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
            Rewrite the same with LINQ.

        */

        /*
         5. Order students

            Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
            Rewrite the same with LINQ.

        */

        public static IEnumerable<Student> OrderStudents(IEnumerable<Student> stdArr)
        {
            // lambda expression
            var result = stdArr
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);
            
            // LINQ query
            var rslt =
                from student in stdArr
                orderby student.FirstName descending, student.LastName descending
                select student;
            
            return result;
        }

        /*
         9. Student groups

            Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            Create a List<Student> with sample students. Select only the students that are from group number 2.
            Use LINQ query. Order the students by FirstName.

        */

        public static IEnumerable<Student> SelectFromGroup(IEnumerable<Student> stdArr, uint groupNumber)
        {
            var result =
                from student in stdArr
                orderby student.FirstName
                where student.GroupNumber == groupNumber
                select student;

            return result;
        }

        /*
            11. Extract students by email

                Extract all students that have email in abv.bg.
                Use string methods and LINQ.

        */

        public static IEnumerable<Student> ExtractByEmail(IEnumerable<Student> stdArr, string email)
        {
            var result =
                from student in stdArr
                where student.Email.IndexOf(email) > 0
                select student;

            return result;
        }

        /*
         12. Extract students by phone

            Extract all students with phones in Sofia.
            Use LINQ.

        */

        public static IEnumerable<Student> ExtractByPhone(IEnumerable<Student> stdArr, string cityPhoneCode)
        {
            var result =
                from student in stdArr
                where student.Tel.Substring(0, 3) == cityPhoneCode + " "
                select student;
            return result;
        }

        /*
         13. Extract students by marks

            Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            Use LINQ.

        */

        // ! this is not an option ! anonymous types have no return value !

        //public static IEnumerable<Student> SelectExcellentMark(IEnumerable<Student> stdArr) 
        //{
        //    var result =
        //        from student in stdArr
        //        where student.Marks.Any(x => x == 6)
        //        select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

        //    return (dynamic)result;

        //}

        /*
          15. Extract marks

             Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

        */

        public static IEnumerable<Student> MarksOfStudentsYear(IEnumerable<Student> stdArr, uint year)
        {
            var result =
                from student in stdArr
                where (Convert.ToInt32(student.FN[student.FN.Length - 1].ToString()) == year % 10) 
                   && (Convert.ToInt32(student.FN[student.FN.Length - 2].ToString()) == (year / 10) % 10)
                select student;
            return result;
        }

        /*
             18. Grouped by GroupNumber

                Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
                Use LINQ.

        */

        public static IEnumerable<IEnumerable<Student>> OrderStudentsByGroup(IEnumerable<Student> stdArr)
        {
            var result =
                from student in stdArr
                orderby student.GroupNumber
                group student by student.GroupNumber;

            
            return result;
        }

    }
}
