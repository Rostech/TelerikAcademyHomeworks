

namespace Extension_Delegates_AndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    class StartingPoint
    {
        static void Main(string[] args)
        {
            /*
             1. StringBuilder.Substring

                Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

            */

            Console.WriteLine("\n1. " + new string('-', 76) + "\n");
            StringBuilder p = new StringBuilder();
            p.Append("Homework: Extension-Methods-Delegates-Lambda-LINQ");
            p = p.Substring(9,17);
            Console.WriteLine(p.ToString());

            /*
             2. IEnumerable extensions

                Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

            */
            Console.WriteLine("\n2. " + new string('-', 76) + "\n");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(50);
            Console.WriteLine("Sum of the elements : " + numbers.Sum());
            Console.WriteLine("Product of the elements: " + numbers.Product());
            Console.WriteLine("The min element is: " + numbers.Min());
            Console.WriteLine("The max element is: " + numbers.Max());
            Console.WriteLine("The average is : " + numbers.Average());

            /*
             3. First before last

                Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
                Use LINQ query operators.

            */
            Console.WriteLine("\n3. " + new string('-', 76) + "\n");

            var arrWithSudents = new []{
                new Student("Dragan", "Petrov"),
                new Student("Ivan", "Petrov"),
                new Student("Dragan", "Aski"),
                new Student("Silvena", "Stanislavova")
            };

            var firstBeforeLast = Student.FirstBeforeLast(arrWithSudents);
            Console.WriteLine("Students that first name is before their's last name alphabeticly:");
            foreach(var student in firstBeforeLast)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            /*
             4. Age range

                Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            */
            Console.WriteLine("\n4. " + new string('-', 76) + "\n");

            var arrWithSudentsAndAge = new[]{
                new Student("Dragan", "Petrov" , 17),
                new Student("Ivan", "Petrov", 21),
                new Student("Dragan", "Aski", 23),
                new Student("Silvena", "Stanislavova", 24)
            };

            var ageBetween = Student.AgeRange(arrWithSudentsAndAge);
            Console.WriteLine("Students that are beween 18 and 24 years old:");
            foreach (var student in ageBetween)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            /*
             5. Order students

                Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
                Rewrite the same with LINQ.

            */
            Console.WriteLine("\n5. " + new string('-', 76) + "\n");

            var orderStudents = new[]{
                new Student("Dragan", "Petrov"),
                new Student("Ivan", "Petrov"),
                new Student("Dragan", "Aski"),
                new Student("Silvena", "Stanislavova")
            };

            var orderStudentsResult = Student.OrderStudents(orderStudents);
            Console.WriteLine("Students ordered by first name then by last name (descending):");
            foreach (var student in orderStudentsResult)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            /*
             6. Divisible by 7 and 3

                    Write a program that prints from given array of integers all numbers that are 
                    divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            */

            Console.WriteLine("\n6. " + new string('-', 76) + "\n");
            var arr = new int[] { 21, 63, 15, 87, 63, 15, 42 };
            var devisibleBy7And3 = DevisibleBy7And3.DevisibleBy7and3(arr);
            Console.WriteLine("Numbers devisible by 7 and 3: ");
            Console.WriteLine("From: " + string.Join(",",arr));
            Console.WriteLine("Result: " + string.Join(",", devisibleBy7And3));

            /*
             7. Timer

                Using delegates write a class Timer that can execute certain method at each t seconds.

            */

            Console.WriteLine("\n7. " + new string('-', 76) + "\n");
            DelegateTask7 method = new DelegateTask7(Task7Method);
            uint seconds = 5;
            Console.WriteLine("Wait for {0} {1}. \n", seconds,seconds != 1 ? "seconds" : "second");
            Timer newTimer = new Timer(1, method, 5); // -----------------------------------------------------------------
            newTimer.StartTimer();
            Console.WriteLine();

            /*
             9. Student groups

                Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
                Create a List<Student> with sample students. Select only the students that are from group number 2.
                Use LINQ query. Order the students by FirstName.

            */

            Console.WriteLine("\n9. " + new string('-', 76) + "\n");
            List<Student> studentListTask9 = new List<Student>();
            studentListTask9.Add(new Student("Petkan", "Slavchev", null, null, null, null, null, 2));
            studentListTask9.Add(new Student("Dragan", "Penchev", null, null, null, null, null, 4));
            studentListTask9.Add(new Student("Stamat", "Iordanov", null, null, null, null, null, 1));
            studentListTask9.Add(new Student("Katq", "Darinova", null, null, null, null, null, 2));
            Console.WriteLine("All students: ");
            foreach (var student in studentListTask9)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.GroupNumber);
            }

            var studentsFromGroup2 = Student.SelectFromGroup(studentListTask9, 2);
            
            Console.WriteLine("\nStudents from group 2: ");
            foreach(var student in studentsFromGroup2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.GroupNumber);
            }
            /*
             10. Student groups extensions

                Implement the previous using the same query expressed with extension methods.

            */

            Console.WriteLine("\n10. " + new string('-', 75) + "\n");

            var studentsFromGroup2WithExtension = StudentExtensions.SelectFromGroupExtension(studentListTask9, 2);
            foreach (var student in studentsFromGroup2WithExtension)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.GroupNumber);
            }

            /*
            11. Extract students by email

                Extract all students that have email in abv.bg.
                Use string methods and LINQ.

            */

            Console.WriteLine("\n11. " + new string('-', 75) + "\n");
            List<Student> studentsWithEmail = new List<Student>();
            studentsWithEmail.Add(new Student("Petkan", "Slavchev", null, null, null, "pesho@abv.bg", null, 2));
            studentsWithEmail.Add(new Student("Dragan", "Penchev", null, null, null, "uuuUuuu@gmail.bg", null, 4));
            studentsWithEmail.Add(new Student("Stamat", "Iordanov", null, null, null, "ObamaStan@yahoo.bg", null, 1));
            studentsWithEmail.Add(new Student("Katq", "Darinova", null, null, null, "dupnicaBG@abv.bg", null, 2));

            Console.WriteLine("All students: ");
            foreach (var student in studentsWithEmail)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Email);
            }
            Console.WriteLine();
            Console.WriteLine("\nStudents with email in abv.bg :");

            var studentsWithEmailInAbv = Student.ExtractByEmail(studentsWithEmail, "@abv.bg");
            foreach (var student in studentsWithEmailInAbv)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Email);
            }

            /*
                12. Extract students by phone

                   Extract all students with phones in Sofia.
                   Use LINQ.

            */
            Console.WriteLine("\n12. " + new string('-', 75) + "\n");
            List<Student> studentsWithPhone = new List<Student>();
            studentsWithPhone.Add(new Student("Petkan", "Slavchev", null, null, "02 15 21 321", "pesho@abv.bg", null, 2));
            studentsWithPhone.Add(new Student("Dragan", "Penchev", null, null, "022 15 21 321", "uuuUuuu@gmail.bg", null, 4));
            studentsWithPhone.Add(new Student("Stamat", "Iordanov", null, null, "02 15 21 321", "ObamaStan@yahoo.bg", null, 1));
            studentsWithPhone.Add(new Student("Katq", "Darinova", null, null, "012 15 21 321", "dupnicaBG@abv.bg", null, 2));

            Console.WriteLine("All students: ");
            foreach (var student in studentsWithPhone)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Tel);
            }

            Console.WriteLine();
            Console.WriteLine("\nStudents with phone in Sofia : ");

            var studentsWithPhoneInSofia = Student.ExtractByPhone(studentsWithPhone, "02");
            foreach (var student in studentsWithPhoneInSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Tel);
            }

            /*
                13. Extract students by marks

                   Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
                   Use LINQ.

             */

            Console.WriteLine("\n13. " + new string('-', 75) + "\n");
            List<Student> studentsWithMarks = new List<Student>();
            studentsWithMarks.Add(new Student("Petkan", "Slavchev", null, null, "02 15 21 321", "pesho@abv.bg", new List<double>(new double[] {2,3,4,5}), 2));
            studentsWithMarks.Add(new Student("Dragan", "Penchev", null, null, "022 15 21 321", "uuuUuuu@gmail.bg", new List<double>(new double[] { 2, 3, 6, 5 }), 4));
            studentsWithMarks.Add(new Student("Stamat", "Iordanov", null, null, "02 15 21 321", "ObamaStan@yahoo.bg", new List<double>(new double[] { 2, 2, 4, 5 }), 1));
            studentsWithMarks.Add(new Student("Katq", "Darinova", null, null, "012 15 21 321", "dupnicaBG@abv.bg", new List<double>(new double[] { 2, 3, 4, 5 }), 2));

            Console.WriteLine("All students: ");
            foreach (var student in studentsWithMarks)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks));
            }
            var result =
                from student in studentsWithMarks
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
            Console.WriteLine();
            Console.WriteLine("People with excelent mark: ");

            foreach (var student in result)
            {
                Console.WriteLine(student.FullName);
            }

            /*
             14. Extract students with two marks

                 Write down a similar program that extracts the students with exactly two marks "2".
                 Use extension methods.

            */

            Console.WriteLine("\n14. " + new string('-', 75) + "\n");
            List<Student> studentsWith2Marks2 = new List<Student>();
            studentsWith2Marks2.Add(new Student("Petkan", "Slavchev", null, null, "02 15 21 321", "pesho@abv.bg", new List<double>(new double[] { 2, 3, 4, 5 }), 2));
            studentsWith2Marks2.Add(new Student("Dragan", "Penchev", null, null, "022 15 21 321", "uuuUuuu@gmail.bg", new List<double>(new double[] { 2, 3, 6, 5 }), 4));
            studentsWith2Marks2.Add(new Student("Stamat", "Iordanov", null, null, "02 15 21 321", "ObamaStan@yahoo.bg", new List<double>(new double[] { 2, 2, 4, 5 }), 1));
            studentsWith2Marks2.Add(new Student("Katq", "Darinova", null, null, "012 15 21 321", "dupnicaBG@abv.bg", new List<double>(new double[] { 2, 3, 4, 5 }), 2));

            Console.WriteLine("All students: ");
            foreach (var student in studentsWith2Marks2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks));
            }
            var studentWit2mark2 = StudentExtensions.StudentsWithTwoMarks(studentsWith2Marks2, 2, 2);
            Console.WriteLine();
            Console.WriteLine("People with 2  mark 2 : ");

            foreach (var student in studentWit2mark2)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks)); 
            }

            /*
             15. Extract marks

                Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            */

            Console.WriteLine("\n15. " + new string('-', 75) + "\n");
            List<Student> studentsMarksYear = new List<Student>();
            studentsMarksYear.Add(new Student("Petkan", "Slavchev", null, "110206", "02 15 21 321", "pesho@abv.bg", new List<double>(new double[] { 2, 3, 4, 5 }), 2));
            studentsMarksYear.Add(new Student("Dragan", "Penchev", null, "110202", "022 15 21 321", "uuuUuuu@gmail.bg", new List<double>(new double[] { 2, 3, 6, 5 }), 4));
            studentsMarksYear.Add(new Student("Stamat", "Iordanov", null, "110221", "02 15 21 321", "ObamaStan@yahoo.bg", new List<double>(new double[] { 2, 2, 4, 5 }), 1));
            studentsMarksYear.Add(new Student("Katq", "Darinova", null, "110206", "012 15 21 321", "dupnicaBG@abv.bg", new List<double>(new double[] { 2, 3, 4, 5 }), 2));

            Console.WriteLine("All students: ");
            foreach (var student in studentsMarksYear)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + " "  + student.FN.ToString()+ " "  +  string.Join(", ", student.Marks));
            }
            var studentMarkYear = Student.MarksOfStudentsYear(studentsMarksYear, 2006);
            Console.WriteLine(studentMarkYear);
            Console.WriteLine();
            Console.WriteLine("Students enrolled in 2006 (their marks) : ");
            foreach (var student in studentMarkYear)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + string.Join(", ", student.Marks)); 
            }

            /*
             17. Longest string

                Write a program to return the string with maximum length from an array of strings.
                Use LINQ.

            */
            Console.WriteLine("\n17. " + new string('-', 75) + "\n");
            string[] arrWithStrings = new string[]
                {
                    "pesho", "dragan", "brustakurta", "problem"
                };
            Console.WriteLine("Arr with strings: \n" + string.Join(", ", arrWithStrings) + "\n");
            string longest = arrWithStrings.ReturnLongestString<string>();
            Console.WriteLine("The longest string: " + longest);

            /*
             18. Grouped by GroupNumber

                Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
                Use LINQ.

            */
            Console.WriteLine("\n18. " + new string('-', 75) + "\n");

            List<Student> gorupedStudentsByGroup = new List<Student>();
            gorupedStudentsByGroup.Add(new Student("Petkan", "Slavchev", null, null, null, null, null, 2));
            gorupedStudentsByGroup.Add(new Student("Dragan", "Penchev", null, null, null, null, null, 4));
            gorupedStudentsByGroup.Add(new Student("Stamat", "Iordanov", null, null, null, null, null, 1));
            gorupedStudentsByGroup.Add(new Student("Katq", "Darinova", null, null, null, null, null, 2));
            gorupedStudentsByGroup.Add(new Student("Pencho", "Hristov", null, null, null, null, null, 5));
            gorupedStudentsByGroup.Add(new Student("Slaveq", "Pincheva", null, null, null, null, null, 1));
            gorupedStudentsByGroup.Add(new Student("Katq", "Darinova", null, null, null, null, null, 2));
            Console.WriteLine("All students: ");
            foreach (var student in gorupedStudentsByGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.GroupNumber);
            }

            var gorupedStudentsByGroupRslt = Student.OrderStudentsByGroup(gorupedStudentsByGroup);

            Console.WriteLine("\nStudents sordet by groups: ");
            foreach (var group in gorupedStudentsByGroupRslt)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("{0} {1} is in group {2}", student.FirstName, student.LastName, student.GroupNumber);
                }
            }

            /*
                19. Grouped by GroupName extensions

                    Rewrite the previous using extension methods

            */

            Console.WriteLine("\n19. " + new string('-', 75) + "\n");

            gorupedStudentsByGroupRslt = StudentExtensions.GroupName(gorupedStudentsByGroup);

            Console.WriteLine("\nStudents sordet by groups: ");
            foreach (var group in gorupedStudentsByGroupRslt)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("{0} {1} is in group {2}", student.FirstName, student.LastName, student.GroupNumber);
                }
            }

        }

        #region task7

        public delegate void DelegateTask7();
        public static void Task7Method()
        {
            Console.Write("Hello!");
        }

        #endregion
    }
}
