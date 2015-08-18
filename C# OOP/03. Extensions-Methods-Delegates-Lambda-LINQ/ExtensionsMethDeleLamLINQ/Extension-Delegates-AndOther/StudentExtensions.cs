

namespace Extension_Delegates_AndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   

    public static class StudentExtensions
    {
        /*
            10. Student groups extensions

               Implement the previous using the same query expressed with extension methods.
        */

        public static IEnumerable<Student> SelectFromGroupExtension(IEnumerable<Student> stdArr, int groupNumber)
        {
             var result =
                from student in stdArr
                orderby student.FirstName
                where student.GroupNumber == groupNumber
                select student;

            return result;
        }

        /*
         14. Extract students with two marks

            Write down a similar program that extracts the students with exactly two marks "2".
            Use extension methods.

        */

        public static IEnumerable<Student> StudentsWithTwoMarks(IEnumerable<Student> stdArr, double mark, int timesCount)
        {
            var result =
                from student in stdArr
                where student.Marks.CountNumberInCollecion(mark, timesCount)
                select student;
            return result;
        }

        /*
               19. Grouped by GroupName extensions

                   Rewrite the previous using extension methods

        */

        public static IEnumerable<IEnumerable<Student>> GroupName(IEnumerable<Student> stdArr)
        {
            var result =
                from student in stdArr
                orderby student.GroupNumber
                group student by student.GroupNumber;


            return result;
        }
    }
}
