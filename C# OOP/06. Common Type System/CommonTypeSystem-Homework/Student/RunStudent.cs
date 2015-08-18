using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class RunStudent
    {
        static void Main()
        {
            Student Pesho = new Student("Pesho", "P", "Peshev", "12344", "Sofia", "08989898989", "peshoPeshev@gmai.com");
            Pesho.FillUniversityInfo(Student.UniversityEnum.SofiaUniversity, 2, Student.FacultyEnum.Mathematics, Student.SpecialityEnum.Programming);

            Student Gosho = new Student("Gosho", "G", "Goshev", "12345", "Sofia", "08987362526", "goshoGoshev@gmai.com");
            Gosho.FillUniversityInfo(Student.UniversityEnum.UNSS, 3, Student.FacultyEnum.Economy, Student.SpecialityEnum.BussinesRelations);

            Console.WriteLine(Pesho);
            Console.WriteLine(Gosho);
            Console.WriteLine(Pesho == Gosho);
            Console.WriteLine(Pesho.Equals(Pesho));
            Console.WriteLine(Pesho.Equals(Gosho));
            Console.WriteLine(Pesho != Gosho);

        }
    }
}
