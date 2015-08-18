using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void CreatingNewSchoolWithValidNameAndIdShouldNotThrowException()
        {
            School school = new School("Hogwards");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingNewSchooltWithInvalidNameShouldThrowException()
        {
            School course = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentShouldThrow()
        {
            School school = new School("Hogwards");
            school.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingExistingStudentShouldThrow()
        {
            School school = new School("Hogwards");
            Student student = new Student("Stamat", 10000);

            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingStudentWithExistingIdShouldThrow()
        {
            School school = new School("Hogwards");
            Student student = new Student("Stamat", 10000);
            Student studentWithSameID = new Student("Pesho", 10000);

            school.AddStudent(student);
            school.AddStudent(studentWithSameID);
        }

        [TestMethod]
        public void AddingStudentShouldNotThrow()
        {
            School school = new School("Hogwards");
            Student student = new Student("Stamat", 10000);

            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingStudenThatDoesntExistShouldThrow()
        {
            School school = new School("Hogwards");
            Student student = new Student("Stamat", 10000);

            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingStudenThatIsNullShouldThrow()
        {
            School school = new School("Hogwards");
            school.RemoveStudent(null);
        }

        [TestMethod]
        public void RemovingStudentShouldNotThrow()
        {
            School school = new School("Hogwards");
            Student student = new Student("Stamat", 10000);

            school.AddStudent(student);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void AddingCourseShouldNotThrow()
        {
            School school = new School("Hogwards");
            Course course = new Course("BatCourse");

            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullCourseShouldThrow()
        {
            School school = new School("Hogwards");
            school.AddCourse(null);
        }

        [TestMethod]
        public void AddingCourseAndThanRemovingItShouldNotThrow()
        {
            School school = new School("Hogwards");
            Course course = new Course("BatCourse");

            school.AddCourse(course);
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingCourseThatAlreadyExistsShouldThrow()
        {
            School school = new School("Hogwards");
            Course course = new Course("BatCourse");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingCourseThatDoesNotExistsShouldThrow()
        {
            School school = new School("Hogwards");
            Course course = new Course("BatCourse");
            school.RemoveCourse(course);
        }
    }
}
