using ApiTests.User;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace ApiTestsUser
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void CreateStudent_ShouldAddStudentToDictionary()
        {
            // Arrange
            var studentRepository = new Mock<StudentRepository>() { CallBase = true };
            var student = new Student
            {
                Name = "John Doe",
                Age = 20
            };

            // Configure the mock to mock the CreateStudent method
            studentRepository.Setup(r => r.CreateStudent(student)).Returns(student);

            // Act
            var createdStudent = studentRepository.Object.CreateStudent(student);
            createdStudent.Age = 25;
            studentRepository.Object.UpdateStudent(createdStudent);
            var retrievedStudent = studentRepository.Object.GetStudent(createdStudent);

            // Assert
            Assert.AreEqual(createdStudent, retrievedStudent);
            Assert.AreEqual(25, retrievedStudent.Age);
        }
    }
}