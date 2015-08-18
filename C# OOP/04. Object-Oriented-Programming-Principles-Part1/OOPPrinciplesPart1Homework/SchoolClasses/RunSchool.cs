
namespace SchoolClasses
{
    using System;
    using SchoolClasses.Models;


    class RunSchool
    {
        /*
            School classes: 

                We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of 
                disciplines. Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. Disciplines have 
                a name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines 
                could have optional comments (free text block).
                Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class 
                hierarchy and create a class diagram with Visual Studio.

        */
        static void Main()
        {
            var listWithStudents = new Student[]
            {
                new Student("Ivan", "1221"),
                new Student("Stefan", "1222"),
                new Student("Petkan", "1223"),
                new Student("Dimitrinka", "1224"),
                new Student("Leila", "1225"),

            };

            listWithStudents[0].AddComment("This student is very smart.");
            listWithStudents[0].AddComment("Just kidding :D");
            listWithStudents[3].AddComment("This is a boy!");

            var listWithDisciplines = new Discipline[]
            {
                new Discipline("Math", 25, 25),
                new Discipline("Programming with c#", 30, 30),
                new Discipline("Programming with Java", 30, 25),
                new Discipline("Algorithms", 30, 15),
                new Discipline("Multimedia hardware", 15, 20),
                new Discipline("English", 25, 25),
                new Discipline("Computer graphics", 25, 25),
            };

            listWithDisciplines[0].AddComment("This discipline is very hard!");
            listWithDisciplines[4].AddComment("This discipline is meaningless");

            var listOfTechers = new Teacher[]
            {
                new Teacher("Doncho Minkov", listWithDisciplines[1], listWithDisciplines[2], listWithDisciplines[6]),
                new Teacher("Niki ", listWithDisciplines[0]),
                new Teacher("Ivo", listWithDisciplines[4]),
                new Teacher("Evlogi Hristov", listWithDisciplines[5], listWithDisciplines[3])
            };
            listOfTechers[0].AddComment(string.Format("{0} explains well", listOfTechers[0].Name));
            listOfTechers[3].AddComment("He explains well");

            var listOfClasses = new Class[]
            {
                new Class("1+", listOfTechers),
                new Class("2+", listOfTechers[0]),
                new Class("3+", listOfTechers[0], listOfTechers[1], listOfTechers[3]),
            };

            listOfClasses[0].AddStudents(listWithStudents);
            listOfClasses[1].AddStudents(listWithStudents[0], listWithStudents[1]);
            listOfClasses[2].AddStudents(listWithStudents[0], listWithStudents[1], listWithStudents[3]);

            var newSchool = new School(listOfClasses);
            Console.WriteLine(newSchool);

        }
    }
}
