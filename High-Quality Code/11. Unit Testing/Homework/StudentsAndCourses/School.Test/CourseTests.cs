using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CreatingNewCourseWithValidNameAndIdShouldNotThrowException()
        {
            Course student = new Course("Batman trainig 101");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingNewCourseWithInvalidNameShouldThrowException()
        {
            Course course = new Course(null);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentShouldThrow()
        {
            Course course = new Course("Batman trainig 101");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingExistingStudentShouldThrow()
        {
            Course course = new Course("Batman trainig 101");
            Student newStudent = new Student("Stamat", 10000);
            course.AddStudent(newStudent);
            course.AddStudent(newStudent);
        }

        [TestMethod]
        public void AddingThirtyStudentsShouldNotThrow()
        {
            Course course = new Course("Batman trainig 101");
            for(int i = 0; i < 30; i++)
            {
                Student newStudent = new Student("Stamat", 10000 + i);
                course.AddStudent(newStudent);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingThirtyOneStudentsShouldNotThrow()
        {
            Course course = new Course("Batman trainig 101");
            for (int i = 0; i < 31; i++)
            {
                Student newStudent = new Student("Stamat", 10000 + i);
                course.AddStudent(newStudent);
            }
        }

        [TestMethod]
        public void AddingThirtyStudentsAndThanRemovingThemShouldNotThrow()
        {
            Course course = new Course("Batman trainig 101");
            Student[] students = new Student[30];
            for (int i = 0; i < 30; i++)
            {
                Student newStudent = new Student("Stamat", 10000 + i);
                students[i] = newStudent;
                course.AddStudent(newStudent);
            }

            for (int i = 0; i < 29; i++)
            {
                course.RemoveStudent(students[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingMissingStudentsShouldThrow()
        {
            Course course = new Course("Batman trainig 101");
            Student newStudent = new Student("Stamat", 10000);
            course.RemoveStudent(newStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingNullStudentsShouldThrow()
        {
            Course course = new Course("Batman trainig 101");
            course.RemoveStudent(null);
        }
    }
}
