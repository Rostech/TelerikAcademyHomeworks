namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void CreatingNewStudentWithValidNameAndIdShouldNotThrowException()
        {
            Student student = new Student("Pesho", 10000);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void CreatingNewStudentWithInvalidNameShouldThrowException()
        {
            Student student = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingNewStudentWithInvalidIdShouldThrowException()
        {
            Student student = new Student("Stamat", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EnrollingStudentToNullableCourseShouldThrowAnException()
        {
            Student student = new Student("Stamat", 10000);
            Course course = null;
            student.EnrollCourse(course);
        }

        [TestMethod]
        public void EnrollingStudentToCourseShouldNotThrowAnException()
        {
            Student student = new Student("Stamat", 10000);
            Course course = new Course("Batman training");
            student.EnrollCourse(course);
        }

        [TestMethod]
        public void EnrollingAndUnsubscribingStudentToCourseShouldNotThrowAnException()
        {
            Student student = new Student("Stamat", 10000);
            Course course = new Course("Batman training");
            student.EnrollCourse(course);
            student.UnsubscribeCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UnsubscribingNullCourseShouldThrowAnException()
        {
            Student student = new Student("Stamat", 10000);
            student.UnsubscribeCourse(null);
        }
    }
}
