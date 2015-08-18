
namespace StudentsAndWorkers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentsAndWorkers.Models;


    class RunStudentsAndWorkers
    {
        /*
            
            Define abstract class Human with a first name and a last name. Define a new class Student which is derived from 
            Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay 
            and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties 
            for this hierarchy.
            Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            Initialize a list of 10 workers and sort them by money per hour in descending order.
            Merge the lists and sort them by first name and last name.

        */
        static void Main()
        {
            List<Student> listWithStudents = new List<Student>();
            listWithStudents.Add(new Student("Slavka", "Zdravkova", 1));
            listWithStudents.Add(new Student("Zahari", "Stoqnov", 1));
            listWithStudents.Add(new Student("Slavi", "Trifonov", 3));
            listWithStudents.Add(new Student("Pencho", "Hristov", 4));
            listWithStudents.Add(new Student("Martin", "Moroz", 1));
            listWithStudents.Add(new Student("Evlogi", "Hristov", 6));
            listWithStudents.Add(new Student("Peter", "Stoqnov", 8));
            listWithStudents.Add(new Student("Stamat", "Petrov", 12));
            listWithStudents.Add(new Student("Pesho", "Stamatev", 11));
            listWithStudents.Add(new Student("Balcho", "Telefonski", 6));
            // sort the students by grade in ascending order
            listWithStudents = listWithStudents.OrderBy(s => s.Grade).ToList();

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in listWithStudents)
            {
                Console.WriteLine("{0} {1} in grade {2}", item.FirstName, item.LastName, item.Grade);
            }
            Console.WriteLine();
            List<Worker> listWithWorkers = new List<Worker>();
            listWithWorkers.Add( new Worker("Peter", "Ivanov", 150.3, 6));
            listWithWorkers.Add( new Worker("Stamat", "Petrov", 20.1, 8));
            listWithWorkers.Add( new Worker("Iron", "Man", 15, 2));
            listWithWorkers.Add( new Worker("Goshkata", "Batman", 332.99, 23));
            listWithWorkers.Add( new Worker("Dimitrinka", "Hisheva", 123, 15));
            listWithWorkers.Add( new Worker("Pesho", "Kovalski", 150, 3));
            listWithWorkers.Add( new Worker("Gancho", "Rodriges", 150.4, 7));
            listWithWorkers.Add( new Worker("Petka", "Pincheva", 150.5, 6));
            listWithWorkers.Add( new Worker("Simeon", "Minule", 5, 6));
            listWithWorkers.Add( new Worker("Gandalf", "Vrachanski", 1, 0.20));
            // sort the workers bt money per hour in descending order
            listWithWorkers = listWithWorkers.OrderByDescending(w => w.MoneyPerHour()).ToList();

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in listWithWorkers)
            {
                Console.WriteLine("{0} {1} works for {2:C2} a week {3} h/d (5 days a week) => {4:C2}/h", item.FirstName,
                                        item.LastName, item.WeekSalary, item.WorkHoursPerDay, item.MoneyPerHour());
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Merging and sorting lists by first name and by last name");
            Console.WriteLine();
            // mergin and sortig

            var list = new List<Human>();
            list.AddRange(listWithStudents);
            list.AddRange(listWithWorkers);

            list = list.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(" {0} {1} ({2})", item.FirstName, item.LastName, item.GetType().Name);   
            }

        }
    }
}
